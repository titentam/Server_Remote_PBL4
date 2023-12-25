using ControlCustom;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class ClientHandler
    {
        private TcpClient client;
        private NetworkStream stream;
        private BinaryReader reader;
        private BinaryWriter writer;
        public bool isConnected;
        private string passServer;
        private VoiceIn voiceIn;
        private VoiceOut voiceOut;
        private bool isListening;

        public ClientHandler(TcpClient client, string passClient)
        {
            this.client = client;
            this.stream = client.GetStream();
            this.reader = new BinaryReader(stream); 
            this.writer = new BinaryWriter(stream);
            this.isConnected = true;
            this.passServer = passClient;
            InitVoice();
        }
        private void InitVoice()
        {
            var hostname = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
            voiceIn = new VoiceIn(hostname,6969); 

            WaveFormat waveFormat = new WaveFormat(44100,1);
            voiceOut = new VoiceOut(waveFormat, 6969); // listening port 6969
            isListening = false;
        }

        public void SendMessage(string message)
        {
            writer.Write(message);
            stream.Flush();
        }
        public void SendDesktop(int fps = 60)
        {
            while (isConnected)
            {
                try
                {
                    var bitmap = ScreenCus.CaptureScreen(false);

                    byte[] bitmapBytes = DataHelper.BitmapToByteArray(bitmap);

                    writer.Write(bitmapBytes.Length);

                    writer.Write(bitmapBytes);

                    stream.Flush();
                    Thread.Sleep(1000 / fps);
                }
                catch (Exception)
                {
                    MessageBox.Show("Client had disconnected!");
                    this.Stop();
                    break;
                }
                
            }
            
        }
        public void ReceiveClientMessage()
        {
            while (isConnected)
            {
                ClientMessage clientMessage;
                try
                {
                    clientMessage = (ClientMessage)reader.ReadByte();
                }
                catch (Exception)
                {
                    this.Stop();
                    break;
                }
                
                switch (clientMessage)
                {
                    case ClientMessage.MOUSE_MOVE:
                        {
                            int x=0, y=0;
                            ReceivePosition(ref x, ref y);
                            MouseCus.MouseMove(x, y);
                                break;
                        }
                    case ClientMessage.MOUSE_LEFT_DOWN:
                        {
                            int x = 0, y = 0;
                            ReceivePosition(ref x, ref y);
                            MouseCus.MouseDown(x, y);
                            break;
                        }
                    case ClientMessage.MOUSE_LEFT_UP:
                        {
                            int x = 0, y = 0;
                            ReceivePosition(ref x, ref y);
                            MouseCus.MouseUp(x, y);
                            break;
                        }
                    case ClientMessage.MOUSE_RIGHT_DOWN:
                        {
                            int x = 0, y = 0;
                            ReceivePosition(ref x, ref y);
                            MouseCus.MouseDown(x, y,InputEventCus.MouseEventF.RightDown);
                            break;
                        }
                    case ClientMessage.MOUSE_RIGHT_UP:
                        {
                            int x = 0, y = 0;
                            ReceivePosition(ref x, ref y);
                            MouseCus.MouseUp(x, y, InputEventCus.MouseEventF.RightUp);
                            break;
                        }
                    case ClientMessage.MOUSE_SCROLL:
                        {
                            int scrollValue = reader.ReadInt32();
                            MouseCus.MouseScroll(scrollValue);
                            break;
                        }
                    case ClientMessage.KEY_UP:
                        {
                            int keyValue = reader.ReadInt32();
                            Keys key = (Keys)keyValue;
                            KeyBoardCus.KeyUp(key);
                            break;
                        }
                    case ClientMessage.KEY_DOWN:
                        {
                            int keyValue = reader.ReadInt32();
                            Keys key = (Keys)keyValue;
                            KeyBoardCus.KeyDown(key);
                            break;
                        }
                    case ClientMessage.MESSAGE:
                        {
                            string message = reader.ReadString();
                            
                            break;
                        }
                    default:
                        break;
                }
            }
            
        }

        public void VoiceRecorder()
        {
            VoiceStop();
            Thread t = new Thread(() =>
            {
                voiceIn.StartRecording();
            });
            t.Start();
        }
        public void VoiceStop()
        {
            if(voiceIn != null)
            {
                voiceIn.StopRecording();
            }
            
        }

        public void ReceiveVoice()
        {
            StopReceiveVoice();
            isListening = true;
            voiceOut.Play();
            Thread t = new Thread(() =>
            {
                while (isListening)
                {
                    voiceOut?.ReceiveData();
                }
            });
            t.Start();
        }

        public void StopReceiveVoice()
        {
            
            isListening = false;
            if(voiceOut != null)
            {
                voiceOut.Stop();
            }
            
        }

        public void Stop()
        {
            if(client.Connected)
            {
                isConnected = false;
                client.Close();
            }
            if(voiceOut != null)
            {
                voiceOut.Close();
            }
            if (voiceIn != null)
            {
                voiceIn.Close();
            }
            isConnected = false;
        }

        public void Start()
        {
            // receive pass
            while(!CheckPass()) 
            {
                writer.Write(false); // send rs;
            }
            writer.Write(true);
            MessageBox.Show("Client connected!");

            if (isConnected)
            {
                Thread sendDesktop = new Thread(() =>
                {
                    SendDesktop();
                });
                Thread receiveClientMessage = new Thread(() =>
                {
                    ReceiveClientMessage();
                });
                
                sendDesktop.Start();
                receiveClientMessage.Start();
            }
        }

        private bool CheckPass()
        {
            string passClient = reader.ReadString();
            return passClient == this.passServer;
        }


        private void ReceivePosition(ref int x, ref int y)
        {
            var screenSize = ScreenCus.GetScreenSize();
            var scaleX = reader.ReadDouble();
            var scaleY = reader.ReadDouble();
            x = (int)(screenSize.X * scaleX);
            y = (int)(screenSize.Y * scaleY);
        }


    }
}
