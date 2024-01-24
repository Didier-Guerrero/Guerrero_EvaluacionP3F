namespace Guerrero_EvaluacionP3F.DG_Utilidades
{
    internal class DG_ConexionDB
    {
        public static string DevolverRuta(string nombreBase)
        {
            string rutaBase = string.Empty;
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                rutaBase = Path.Combine(rutaBase, nombreBase);
            }
            else if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                rutaBase = Path.Combine(rutaBase, "..", "Library", nombreBase);
            }
            return rutaBase;
        }
    }
}
