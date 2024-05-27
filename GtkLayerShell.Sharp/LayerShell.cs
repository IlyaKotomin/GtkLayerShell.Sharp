using GtkLayerShell.Sharp.Global;
using static GtkLayerShell.Sharp.Bridge.GtkLayerShellBridge;

namespace GtkLayerShell.Sharp;

public class LayerShell
{
    public static void InitializeForWindow(IntPtr windowHandle)
    {
        gtk_layer_init_for_window(windowHandle);
    }

    public static void SetNamespace(string ns)
    {
        gtk_layer_set_namespace(ns);
    }

    public static void SetMonitor(IntPtr monitorHandle)
    {
        gtk_layer_set_monitor(monitorHandle);
    }

    public static bool AutoExclusiveZoneIsEnabled(IntPtr layerHandle)
    {
        return gtk_layer_auto_exclusive_zone_is_enabled(layerHandle);
    }

    public static void EnableAutoExclusiveZone(bool enable)
    {
        gtk_layer_auto_exclusive_zone_enable(enable);
    }

    public static void SetExclusiveZone(int zone)
    {
        gtk_layer_set_exclusive_zone(zone);
    }

    public static Layer GetLayer(IntPtr layerHandle)
    {
        return gtk_layer_get_layer(layerHandle);
    }

    public static void SetLayer(Layer layer)
    {
        gtk_layer_set_layer(layer);
    }

    public static Edge GetAnchor(IntPtr layerHandle)
    {
        return gtk_layer_get_anchor(layerHandle);
    }

    public static void SetAnchor(Edge edge)
    {
        gtk_layer_set_anchor(edge);
    }

    public static int GetMargin(IntPtr layerHandle)
    {
        return gtk_layer_get_margin(layerHandle);
    }

    public static void SetMargin(int margin)
    {
        gtk_layer_set_margin(margin);
    }

    public static KeyboardMode GetKeyboardMode(IntPtr layerHandle)
    {
        return gtk_layer_get_keyboard_mode(layerHandle);
    }

    public static void SetKeyboardMode(KeyboardMode mode)
    {
        gtk_layer_set_keyboard_mode(mode);
    }
}