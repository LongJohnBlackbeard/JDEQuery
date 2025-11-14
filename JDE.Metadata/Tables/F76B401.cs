using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B401 - .
/// </summary>
public class F76B401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIGPBT.
        /// </summary>
        public const string DIGPBT = "DIGPBT";

        /// <summary>
        /// DIGPTN.
        /// </summary>
        public const string DIGPTN = "DIGPTN";

        /// <summary>
        /// DITAXC.
        /// </summary>
        public const string DITAXC = "DITAXC";

        /// <summary>
        /// DIBRRCT.
        /// </summary>
        public const string DIBRRCT = "DIBRRCT";

        /// <summary>
        /// DIAN8.
        /// </summary>
        public const string DIAN8 = "DIAN8";

        /// <summary>
        /// DITAX.
        /// </summary>
        public const string DITAX = "DITAX";

        /// <summary>
        /// DICO.
        /// </summary>
        public const string DICO = "DICO";

        /// <summary>
        /// DIBCRC.
        /// </summary>
        public const string DIBCRC = "DIBCRC";

        /// <summary>
        /// DIAN01.
        /// </summary>
        public const string DIAN01 = "DIAN01";

        /// <summary>
        /// DIAN02.
        /// </summary>
        public const string DIAN02 = "DIAN02";

        /// <summary>
        /// DIAN03.
        /// </summary>
        public const string DIAN03 = "DIAN03";

        /// <summary>
        /// DIAN04.
        /// </summary>
        public const string DIAN04 = "DIAN04";

        /// <summary>
        /// DIAN05.
        /// </summary>
        public const string DIAN05 = "DIAN05";

        /// <summary>
        /// DIAN06.
        /// </summary>
        public const string DIAN06 = "DIAN06";

        /// <summary>
        /// DIAN07.
        /// </summary>
        public const string DIAN07 = "DIAN07";

        /// <summary>
        /// DIAN08.
        /// </summary>
        public const string DIAN08 = "DIAN08";

        /// <summary>
        /// DIAN09.
        /// </summary>
        public const string DIAN09 = "DIAN09";

        /// <summary>
        /// DIAN10.
        /// </summary>
        public const string DIAN10 = "DIAN10";

        /// <summary>
        /// DIAN11.
        /// </summary>
        public const string DIAN11 = "DIAN11";

        /// <summary>
        /// DIAN12.
        /// </summary>
        public const string DIAN12 = "DIAN12";

        /// <summary>
        /// DIAN13.
        /// </summary>
        public const string DIAN13 = "DIAN13";

        /// <summary>
        /// DIAN14.
        /// </summary>
        public const string DIAN14 = "DIAN14";

        /// <summary>
        /// DIAN15.
        /// </summary>
        public const string DIAN15 = "DIAN15";

        /// <summary>
        /// DIAN16.
        /// </summary>
        public const string DIAN16 = "DIAN16";

        /// <summary>
        /// DIAN17.
        /// </summary>
        public const string DIAN17 = "DIAN17";

        /// <summary>
        /// DIAN18.
        /// </summary>
        public const string DIAN18 = "DIAN18";

        /// <summary>
        /// DIAN19.
        /// </summary>
        public const string DIAN19 = "DIAN19";

        /// <summary>
        /// DIAN20.
        /// </summary>
        public const string DIAN20 = "DIAN20";

        /// <summary>
        /// DIAN21.
        /// </summary>
        public const string DIAN21 = "DIAN21";

        /// <summary>
        /// DIAN22.
        /// </summary>
        public const string DIAN22 = "DIAN22";

        /// <summary>
        /// DIAN23.
        /// </summary>
        public const string DIAN23 = "DIAN23";

        /// <summary>
        /// DIAN24.
        /// </summary>
        public const string DIAN24 = "DIAN24";

        /// <summary>
        /// DIAN25.
        /// </summary>
        public const string DIAN25 = "DIAN25";

        /// <summary>
        /// DIAN26.
        /// </summary>
        public const string DIAN26 = "DIAN26";

        /// <summary>
        /// DIAN27.
        /// </summary>
        public const string DIAN27 = "DIAN27";

        /// <summary>
        /// DIAN28.
        /// </summary>
        public const string DIAN28 = "DIAN28";

        /// <summary>
        /// DIAN29.
        /// </summary>
        public const string DIAN29 = "DIAN29";

        /// <summary>
        /// DIAN30.
        /// </summary>
        public const string DIAN30 = "DIAN30";

        /// <summary>
        /// DIAN31.
        /// </summary>
        public const string DIAN31 = "DIAN31";

        /// <summary>
        /// DIAN32.
        /// </summary>
        public const string DIAN32 = "DIAN32";

        /// <summary>
        /// DIAN33.
        /// </summary>
        public const string DIAN33 = "DIAN33";

        /// <summary>
        /// DIAN34.
        /// </summary>
        public const string DIAN34 = "DIAN34";

        /// <summary>
        /// DIAN35.
        /// </summary>
        public const string DIAN35 = "DIAN35";

        /// <summary>
        /// DIAN36.
        /// </summary>
        public const string DIAN36 = "DIAN36";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F76B401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIGPBT", "DIGPBT", JdeDataType.Numeric, null, true, true),
        new JdeField("DIGPTN", "DIGPTN", JdeDataType.String, 28, true, true),
        new JdeField("DITAXC", "DITAXC", JdeDataType.String, 2),
        new JdeField("DIBRRCT", "DIBRRCT", JdeDataType.Numeric, null, true, true),
        new JdeField("DIAN8", "DIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DITAX", "DITAX", JdeDataType.String, 40),
        new JdeField("DICO", "DICO", JdeDataType.String, 10),
        new JdeField("DIBCRC", "DIBCRC", JdeDataType.String, 6),
        new JdeField("DIAN01", "DIAN01", JdeDataType.Numeric),
        new JdeField("DIAN02", "DIAN02", JdeDataType.Numeric),
        new JdeField("DIAN03", "DIAN03", JdeDataType.Numeric),
        new JdeField("DIAN04", "DIAN04", JdeDataType.Numeric),
        new JdeField("DIAN05", "DIAN05", JdeDataType.Numeric),
        new JdeField("DIAN06", "DIAN06", JdeDataType.Numeric),
        new JdeField("DIAN07", "DIAN07", JdeDataType.Numeric),
        new JdeField("DIAN08", "DIAN08", JdeDataType.Numeric),
        new JdeField("DIAN09", "DIAN09", JdeDataType.Numeric),
        new JdeField("DIAN10", "DIAN10", JdeDataType.Numeric),
        new JdeField("DIAN11", "DIAN11", JdeDataType.Numeric),
        new JdeField("DIAN12", "DIAN12", JdeDataType.Numeric),
        new JdeField("DIAN13", "DIAN13", JdeDataType.Numeric),
        new JdeField("DIAN14", "DIAN14", JdeDataType.Numeric),
        new JdeField("DIAN15", "DIAN15", JdeDataType.Numeric),
        new JdeField("DIAN16", "DIAN16", JdeDataType.Numeric),
        new JdeField("DIAN17", "DIAN17", JdeDataType.Numeric),
        new JdeField("DIAN18", "DIAN18", JdeDataType.Numeric),
        new JdeField("DIAN19", "DIAN19", JdeDataType.Numeric),
        new JdeField("DIAN20", "DIAN20", JdeDataType.Numeric),
        new JdeField("DIAN21", "DIAN21", JdeDataType.Numeric),
        new JdeField("DIAN22", "DIAN22", JdeDataType.Numeric),
        new JdeField("DIAN23", "DIAN23", JdeDataType.Numeric),
        new JdeField("DIAN24", "DIAN24", JdeDataType.Numeric),
        new JdeField("DIAN25", "DIAN25", JdeDataType.Numeric),
        new JdeField("DIAN26", "DIAN26", JdeDataType.Numeric),
        new JdeField("DIAN27", "DIAN27", JdeDataType.Numeric),
        new JdeField("DIAN28", "DIAN28", JdeDataType.Numeric),
        new JdeField("DIAN29", "DIAN29", JdeDataType.Numeric),
        new JdeField("DIAN30", "DIAN30", JdeDataType.Numeric),
        new JdeField("DIAN31", "DIAN31", JdeDataType.Numeric),
        new JdeField("DIAN32", "DIAN32", JdeDataType.Numeric),
        new JdeField("DIAN33", "DIAN33", JdeDataType.Numeric),
        new JdeField("DIAN34", "DIAN34", JdeDataType.Numeric),
        new JdeField("DIAN35", "DIAN35", JdeDataType.Numeric),
        new JdeField("DIAN36", "DIAN36", JdeDataType.Numeric),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B401_0", "Primary Key on DIGPBT, DIGPTN, DIBRRCT, DIAN8", new[] { "DIGPBT", "DIGPTN", "DIBRRCT", "DIAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B401_2", "Index on DIGPBT, DIGPTN, DITAXC, DIBRRCT, DITAX, DIAN8", new[] { "DIGPBT", "DIGPTN", "DITAXC", "DIBRRCT", "DITAX", "DIAN8" })
    };
}
