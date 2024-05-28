using System.Runtime.InteropServices;
using Gtk;
using GtkLayerShell.Sharp.Global;

// ReSharper disable InconsistentNaming

namespace GtkLayerShell.Sharp;

public static class LayerShell
{
#pragma warning disable SYSLIB1054

    [DllImport("gtk4-layer-shell")]
    private static extern uint gtk_layer_get_major_version();

    public static uint MajorVersion => gtk_layer_get_major_version();

    [DllImport("gtk4-layer-shell")]
    private static extern uint gtk_layer_get_minor_version();

    public static uint MinorVersion => gtk_layer_get_minor_version();

    [DllImport("gtk4-layer-shell")]
    private static extern uint gtk_layer_get_micro_version();

    public static uint MicroVersion => gtk_layer_get_micro_version();

    [DllImport("gtk4-layer-shell")]
    private static extern bool gtk_layer_is_supported();

    public static bool IsSupported => gtk_layer_is_supported();

    [DllImport("gtk4-layer-shell")]
    private static extern uint gtk_layer_get_protocol_version();

    public static uint ProtocolVersion => gtk_layer_get_protocol_version();

    [DllImport("gtk4-layer-shell")]
    private static extern void gtk_layer_init_for_window(IntPtr window);

    public static void InitWindow(Window window) => gtk_layer_init_for_window(window.Handle);

    [DllImport("gtk4-layer-shell")]
    private static extern bool gtk_layer_is_layer_window(IntPtr window);

    public static bool IsLayerWindow(Window window) => gtk_layer_is_layer_window(window.Handle);

    [DllImport("gtk4-layer-shell")]
    private static extern void gtk_layer_set_namespace(IntPtr window, IntPtr name_space);

    public static void SetNamespace(Window window, string @namespace) =>
        gtk_layer_set_namespace(window.Handle, Marshal.StringToCoTaskMemUTF8(@namespace));

    [DllImport("gtk4-layer-shell")]
    private static extern IntPtr gtk_layer_get_namespace(IntPtr window);

    public static string GetNamespace(Window window) =>
        Marshal.PtrToStringUTF8(gtk_layer_get_namespace(window.Handle)) ?? string.Empty;

    [DllImport("gtk4-layer-shell")]
    private static extern void gtk_layer_set_layer(IntPtr window, Layer layer);

    public static void SetLayer(Window window, Layer layer) => gtk_layer_set_layer(window.Handle, layer);

    [DllImport("gtk4-layer-shell")]
    private static extern Layer gtk_layer_get_layer(IntPtr window);

    public static Layer GetLayer(Window window) => gtk_layer_get_layer(window.Handle);

    [DllImport("gtk4-layer-shell")]
    private static extern void gtk_layer_set_anchor(IntPtr window, Edge edge, bool anchor_to_edge);

    public static void SetAnchor(Window window, Edge edge, bool anchorToEdge) =>
        gtk_layer_set_anchor(window.Handle, edge, anchorToEdge);

    [DllImport("gtk4-layer-shell")]
    private static extern bool gtk_layer_get_anchor(IntPtr window, Edge edge);

    public static bool GetAnchor(Window window, Edge edge) => gtk_layer_get_anchor(window.Handle, edge);

    [DllImport("gtk4-layer-shell")]
    private static extern void gtk_layer_set_margin(IntPtr window, Edge edge, int margin_size);

    public static void SetMargin(Window window, Edge edge, int marginSize) =>
        gtk_layer_set_margin(window.Handle, edge, marginSize);

    [DllImport("gtk4-layer-shell")]
    private static extern int gtk_layer_get_margin(IntPtr window, Edge edge);

    public static int GetMargin(Window window, Edge edge) => gtk_layer_get_margin(window.Handle, edge);

    [DllImport("gtk4-layer-shell")]
    private static extern void gtk_layer_set_exclusive_zone(IntPtr window, int exclusive_zone);

    public static void SetExclusiveZone(Window window, int zone) => gtk_layer_set_exclusive_zone(window.Handle, zone);

    [DllImport("gtk4-layer-shell")]
    private static extern int gtk_layer_get_exclusive_zone(IntPtr window);

    public static int GetExclusiveZone(Window window) => gtk_layer_get_exclusive_zone(window.Handle);

    [DllImport("gtk4-layer-shell")]
    private static extern void gtk_layer_auto_exclusive_zone_enable(IntPtr window);

    public static void AutoExclusiveZoneEnable(Window window) => gtk_layer_auto_exclusive_zone_enable(window.Handle);

    [DllImport("gtk4-layer-shell")]
    private static extern bool gtk_layer_auto_exclusive_zone_is_enabled(IntPtr window);

    public static bool AutoExclusiveZoneIsEnabled(Window window) =>
        gtk_layer_auto_exclusive_zone_is_enabled(window.Handle);

    [DllImport("gtk4-layer-shell")]
    private static extern void gtk_layer_set_keyboard_mode(IntPtr window, KeyboardMode mode);

    public static void SetKeyboardMode(Window window, KeyboardMode mode) =>
        gtk_layer_set_keyboard_mode(window.Handle, mode);

    [DllImport("gtk4-layer-shell")]
    private static extern KeyboardMode gtk_layer_get_keyboard_mode(IntPtr window);

    public static KeyboardMode GetKeyboardMode(Window window) => gtk_layer_get_keyboard_mode(window.Handle);

    [DllImport("gtk4-layer-shell")]
    private static extern void gtk_layer_set_keyboard_interactivity(IntPtr window, bool interactivity);

    public static void SetKeyboardInteractivity(Window window, bool interactivity) =>
        gtk_layer_set_keyboard_interactivity(window.Handle, interactivity);

    [DllImport("gtk4-layer-shell")]
    private static extern bool gtk_layer_get_keyboard_interactivity(IntPtr window);

    public static bool GetKeyboardInteractivity(Window window) => gtk_layer_get_keyboard_interactivity(window.Handle);

#pragma warning restore SYSLIB1054
}