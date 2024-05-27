using System.Runtime.InteropServices;
using GtkLayerShell.Sharp.Global;

namespace GtkLayerShell.Sharp.Bridge;

public class GtkLayerShellBridge
{
    
#pragma warning disable SYSLIB1054

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern void gtk_layer_init_for_window(IntPtr windowHandle);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern void gtk_layer_set_namespace([MarshalAs(UnmanagedType.LPStr)] string ns);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern void gtk_layer_set_monitor(IntPtr monitorHandle);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern bool gtk_layer_auto_exclusive_zone_is_enabled(IntPtr layerHandle);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern void gtk_layer_auto_exclusive_zone_enable(bool enable);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern void gtk_layer_set_exclusive_zone(int zone);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern Layer gtk_layer_get_layer(IntPtr layerHandle);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern void gtk_layer_set_layer(Layer layer);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern Edge gtk_layer_get_anchor(IntPtr layerHandle);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern void gtk_layer_set_anchor(Edge edge);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern int gtk_layer_get_margin(IntPtr layerHandle);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern void gtk_layer_set_margin(int margin);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern KeyboardMode gtk_layer_get_keyboard_mode(IntPtr layerHandle);

    [DllImport("gtk-layer-shell", CallingConvention = CallingConvention.Cdecl)]
    protected internal static extern void gtk_layer_set_keyboard_mode(KeyboardMode mode);
    
#pragma warning restore SYSLIB1054
}