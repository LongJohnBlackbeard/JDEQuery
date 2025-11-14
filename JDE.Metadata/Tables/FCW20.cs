using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW20 - .
/// </summary>
public class FCW20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WXJOBS.
        /// </summary>
        public const string WXJOBS = "WXJOBS";

        /// <summary>
        /// WXC9MLNU.
        /// </summary>
        public const string WXC9MLNU = "WXC9MLNU";

        /// <summary>
        /// WXC9MOSA.
        /// </summary>
        public const string WXC9MOSA = "WXC9MOSA";

        /// <summary>
        /// WXC9ITMP.
        /// </summary>
        public const string WXC9ITMP = "WXC9ITMP";

        /// <summary>
        /// WXC9STRC.
        /// </summary>
        public const string WXC9STRC = "WXC9STRC";

        /// <summary>
        /// WXC9LVNO.
        /// </summary>
        public const string WXC9LVNO = "WXC9LVNO";

        /// <summary>
        /// WXC9LVL0.
        /// </summary>
        public const string WXC9LVL0 = "WXC9LVL0";

        /// <summary>
        /// WXC9LVL1.
        /// </summary>
        public const string WXC9LVL1 = "WXC9LVL1";

        /// <summary>
        /// WXC9LVL2.
        /// </summary>
        public const string WXC9LVL2 = "WXC9LVL2";

        /// <summary>
        /// WXC9LVL3.
        /// </summary>
        public const string WXC9LVL3 = "WXC9LVL3";

        /// <summary>
        /// WXC9LVL4.
        /// </summary>
        public const string WXC9LVL4 = "WXC9LVL4";

        /// <summary>
        /// WXC9LVL5.
        /// </summary>
        public const string WXC9LVL5 = "WXC9LVL5";

        /// <summary>
        /// WXC9LVL6.
        /// </summary>
        public const string WXC9LVL6 = "WXC9LVL6";

        /// <summary>
        /// WXC9LVL7.
        /// </summary>
        public const string WXC9LVL7 = "WXC9LVL7";

        /// <summary>
        /// WXC9LVL8.
        /// </summary>
        public const string WXC9LVL8 = "WXC9LVL8";

        /// <summary>
        /// WXC9LVL9.
        /// </summary>
        public const string WXC9LVL9 = "WXC9LVL9";

        /// <summary>
        /// WXKCOO.
        /// </summary>
        public const string WXKCOO = "WXKCOO";

        /// <summary>
        /// WXDOCO.
        /// </summary>
        public const string WXDOCO = "WXDOCO";

        /// <summary>
        /// WXDCTO.
        /// </summary>
        public const string WXDCTO = "WXDCTO";

        /// <summary>
        /// WXMCU.
        /// </summary>
        public const string WXMCU = "WXMCU";

        /// <summary>
        /// WXLOCN.
        /// </summary>
        public const string WXLOCN = "WXLOCN";

        /// <summary>
        /// WXLOTN.
        /// </summary>
        public const string WXLOTN = "WXLOTN";

        /// <summary>
        /// WXC9ITMX1.
        /// </summary>
        public const string WXC9ITMX1 = "WXC9ITMX1";

        /// <summary>
        /// WXC9ITMX2.
        /// </summary>
        public const string WXC9ITMX2 = "WXC9ITMX2";

        /// <summary>
        /// WXC9ITMX3.
        /// </summary>
        public const string WXC9ITMX3 = "WXC9ITMX3";

        /// <summary>
        /// WXC9ITMX4.
        /// </summary>
        public const string WXC9ITMX4 = "WXC9ITMX4";

        /// <summary>
        /// WXC9ITMX5.
        /// </summary>
        public const string WXC9ITMX5 = "WXC9ITMX5";

        /// <summary>
        /// WXC9ITMX6.
        /// </summary>
        public const string WXC9ITMX6 = "WXC9ITMX6";

        /// <summary>
        /// WXC9ITMX7.
        /// </summary>
        public const string WXC9ITMX7 = "WXC9ITMX7";

        /// <summary>
        /// WXC9ITMX8.
        /// </summary>
        public const string WXC9ITMX8 = "WXC9ITMX8";

        /// <summary>
        /// WXC9ITMX9.
        /// </summary>
        public const string WXC9ITMX9 = "WXC9ITMX9";

        /// <summary>
        /// WXC9ITMX10.
        /// </summary>
        public const string WXC9ITMX10 = "WXC9ITMX10";

        /// <summary>
        /// WXC9ITMX11.
        /// </summary>
        public const string WXC9ITMX11 = "WXC9ITMX11";

        /// <summary>
        /// WXC9ITMX12.
        /// </summary>
        public const string WXC9ITMX12 = "WXC9ITMX12";

        /// <summary>
        /// WXC9ITMX13.
        /// </summary>
        public const string WXC9ITMX13 = "WXC9ITMX13";

        /// <summary>
        /// WXC9ITMX14.
        /// </summary>
        public const string WXC9ITMX14 = "WXC9ITMX14";

        /// <summary>
        /// WXC9ITMX15.
        /// </summary>
        public const string WXC9ITMX15 = "WXC9ITMX15";

        /// <summary>
        /// WXC9ITMX16.
        /// </summary>
        public const string WXC9ITMX16 = "WXC9ITMX16";

        /// <summary>
        /// WXC9ITMX17.
        /// </summary>
        public const string WXC9ITMX17 = "WXC9ITMX17";

        /// <summary>
        /// WXC9ITMX18.
        /// </summary>
        public const string WXC9ITMX18 = "WXC9ITMX18";

        /// <summary>
        /// WXC9ITMX19.
        /// </summary>
        public const string WXC9ITMX19 = "WXC9ITMX19";

        /// <summary>
        /// WXC9ITMX20.
        /// </summary>
        public const string WXC9ITMX20 = "WXC9ITMX20";

        /// <summary>
        /// WXC9ITMX21.
        /// </summary>
        public const string WXC9ITMX21 = "WXC9ITMX21";

        /// <summary>
        /// WXC9ITMX22.
        /// </summary>
        public const string WXC9ITMX22 = "WXC9ITMX22";

        /// <summary>
        /// WXC9ITMX23.
        /// </summary>
        public const string WXC9ITMX23 = "WXC9ITMX23";

        /// <summary>
        /// WXC9ITMX24.
        /// </summary>
        public const string WXC9ITMX24 = "WXC9ITMX24";

        /// <summary>
        /// WXC9ITMX25.
        /// </summary>
        public const string WXC9ITMX25 = "WXC9ITMX25";

        /// <summary>
        /// WXC9ITMX26.
        /// </summary>
        public const string WXC9ITMX26 = "WXC9ITMX26";

        /// <summary>
        /// WXC9ITMX27.
        /// </summary>
        public const string WXC9ITMX27 = "WXC9ITMX27";

        /// <summary>
        /// WXC9ITMX28.
        /// </summary>
        public const string WXC9ITMX28 = "WXC9ITMX28";

        /// <summary>
        /// WXC9ITMX29.
        /// </summary>
        public const string WXC9ITMX29 = "WXC9ITMX29";

        /// <summary>
        /// WXC9ITMX30.
        /// </summary>
        public const string WXC9ITMX30 = "WXC9ITMX30";

        /// <summary>
        /// WXC9LN1.
        /// </summary>
        public const string WXC9LN1 = "WXC9LN1";

        /// <summary>
        /// WXC9LN2.
        /// </summary>
        public const string WXC9LN2 = "WXC9LN2";

        /// <summary>
        /// WXC9LN3.
        /// </summary>
        public const string WXC9LN3 = "WXC9LN3";

        /// <summary>
        /// WXC9LN4.
        /// </summary>
        public const string WXC9LN4 = "WXC9LN4";

        /// <summary>
        /// WXC9LN5.
        /// </summary>
        public const string WXC9LN5 = "WXC9LN5";

        /// <summary>
        /// WXC9LN6.
        /// </summary>
        public const string WXC9LN6 = "WXC9LN6";

        /// <summary>
        /// WXC9LN7.
        /// </summary>
        public const string WXC9LN7 = "WXC9LN7";

        /// <summary>
        /// WXC9LN8.
        /// </summary>
        public const string WXC9LN8 = "WXC9LN8";

        /// <summary>
        /// WXC9LN9.
        /// </summary>
        public const string WXC9LN9 = "WXC9LN9";

        /// <summary>
        /// WXC9LN10.
        /// </summary>
        public const string WXC9LN10 = "WXC9LN10";

        /// <summary>
        /// WXC9LN11.
        /// </summary>
        public const string WXC9LN11 = "WXC9LN11";

        /// <summary>
        /// WXC9LN12.
        /// </summary>
        public const string WXC9LN12 = "WXC9LN12";

        /// <summary>
        /// WXC9LN13.
        /// </summary>
        public const string WXC9LN13 = "WXC9LN13";

        /// <summary>
        /// WXC9LN14.
        /// </summary>
        public const string WXC9LN14 = "WXC9LN14";

        /// <summary>
        /// WXC9LN15.
        /// </summary>
        public const string WXC9LN15 = "WXC9LN15";

        /// <summary>
        /// WXC9LN16.
        /// </summary>
        public const string WXC9LN16 = "WXC9LN16";

        /// <summary>
        /// WXC9LN17.
        /// </summary>
        public const string WXC9LN17 = "WXC9LN17";

        /// <summary>
        /// WXC9LN18.
        /// </summary>
        public const string WXC9LN18 = "WXC9LN18";

        /// <summary>
        /// WXC9LN19.
        /// </summary>
        public const string WXC9LN19 = "WXC9LN19";

        /// <summary>
        /// WXC9LN20.
        /// </summary>
        public const string WXC9LN20 = "WXC9LN20";

        /// <summary>
        /// WXC9LN21.
        /// </summary>
        public const string WXC9LN21 = "WXC9LN21";

        /// <summary>
        /// WXC9LN22.
        /// </summary>
        public const string WXC9LN22 = "WXC9LN22";

        /// <summary>
        /// WXC9LN23.
        /// </summary>
        public const string WXC9LN23 = "WXC9LN23";

        /// <summary>
        /// WXC9LN24.
        /// </summary>
        public const string WXC9LN24 = "WXC9LN24";

        /// <summary>
        /// WXC9LN25.
        /// </summary>
        public const string WXC9LN25 = "WXC9LN25";

        /// <summary>
        /// WXC9LN26.
        /// </summary>
        public const string WXC9LN26 = "WXC9LN26";

        /// <summary>
        /// WXC9LN27.
        /// </summary>
        public const string WXC9LN27 = "WXC9LN27";

        /// <summary>
        /// WXC9LN28.
        /// </summary>
        public const string WXC9LN28 = "WXC9LN28";

        /// <summary>
        /// WXC9LN29.
        /// </summary>
        public const string WXC9LN29 = "WXC9LN29";

        /// <summary>
        /// WXC9LN30.
        /// </summary>
        public const string WXC9LN30 = "WXC9LN30";

        /// <summary>
        /// WXC9QTY1.
        /// </summary>
        public const string WXC9QTY1 = "WXC9QTY1";

        /// <summary>
        /// WXC9QTY2.
        /// </summary>
        public const string WXC9QTY2 = "WXC9QTY2";

        /// <summary>
        /// WXC9QTY3.
        /// </summary>
        public const string WXC9QTY3 = "WXC9QTY3";

        /// <summary>
        /// WXC9QTY4.
        /// </summary>
        public const string WXC9QTY4 = "WXC9QTY4";

        /// <summary>
        /// WXC9QTY5.
        /// </summary>
        public const string WXC9QTY5 = "WXC9QTY5";

        /// <summary>
        /// WXC9QTY6.
        /// </summary>
        public const string WXC9QTY6 = "WXC9QTY6";

        /// <summary>
        /// WXC9QTY7.
        /// </summary>
        public const string WXC9QTY7 = "WXC9QTY7";

        /// <summary>
        /// WXC9QTY8.
        /// </summary>
        public const string WXC9QTY8 = "WXC9QTY8";

        /// <summary>
        /// WXC9QTY9.
        /// </summary>
        public const string WXC9QTY9 = "WXC9QTY9";

        /// <summary>
        /// WXC9QTY10.
        /// </summary>
        public const string WXC9QTY10 = "WXC9QTY10";

        /// <summary>
        /// WXC9QTY11.
        /// </summary>
        public const string WXC9QTY11 = "WXC9QTY11";

        /// <summary>
        /// WXC9QTY12.
        /// </summary>
        public const string WXC9QTY12 = "WXC9QTY12";

        /// <summary>
        /// WXC9QTY13.
        /// </summary>
        public const string WXC9QTY13 = "WXC9QTY13";

        /// <summary>
        /// WXC9QTY14.
        /// </summary>
        public const string WXC9QTY14 = "WXC9QTY14";

        /// <summary>
        /// WXC9QTY15.
        /// </summary>
        public const string WXC9QTY15 = "WXC9QTY15";

        /// <summary>
        /// WXC9QTY16.
        /// </summary>
        public const string WXC9QTY16 = "WXC9QTY16";

        /// <summary>
        /// WXC9QTY17.
        /// </summary>
        public const string WXC9QTY17 = "WXC9QTY17";

        /// <summary>
        /// WXC9QTY18.
        /// </summary>
        public const string WXC9QTY18 = "WXC9QTY18";

        /// <summary>
        /// WXC9QTY19.
        /// </summary>
        public const string WXC9QTY19 = "WXC9QTY19";

        /// <summary>
        /// WXC9QTY20.
        /// </summary>
        public const string WXC9QTY20 = "WXC9QTY20";

        /// <summary>
        /// WXC9QTY21.
        /// </summary>
        public const string WXC9QTY21 = "WXC9QTY21";

        /// <summary>
        /// WXC9QTY22.
        /// </summary>
        public const string WXC9QTY22 = "WXC9QTY22";

        /// <summary>
        /// WXC9QTY23.
        /// </summary>
        public const string WXC9QTY23 = "WXC9QTY23";

        /// <summary>
        /// WXC9QTY24.
        /// </summary>
        public const string WXC9QTY24 = "WXC9QTY24";

        /// <summary>
        /// WXC9QTY25.
        /// </summary>
        public const string WXC9QTY25 = "WXC9QTY25";

        /// <summary>
        /// WXC9QTY26.
        /// </summary>
        public const string WXC9QTY26 = "WXC9QTY26";

        /// <summary>
        /// WXC9QTY27.
        /// </summary>
        public const string WXC9QTY27 = "WXC9QTY27";

        /// <summary>
        /// WXC9QTY28.
        /// </summary>
        public const string WXC9QTY28 = "WXC9QTY28";

        /// <summary>
        /// WXC9QTY29.
        /// </summary>
        public const string WXC9QTY29 = "WXC9QTY29";

        /// <summary>
        /// WXC9QTY30.
        /// </summary>
        public const string WXC9QTY30 = "WXC9QTY30";

        /// <summary>
        /// WXLTTR.
        /// </summary>
        public const string WXLTTR = "WXLTTR";

        /// <summary>
        /// WXDRQJ.
        /// </summary>
        public const string WXDRQJ = "WXDRQJ";

        /// <summary>
        /// WXNXTR.
        /// </summary>
        public const string WXNXTR = "WXNXTR";

        /// <summary>
        /// WXC9FILE.
        /// </summary>
        public const string WXC9FILE = "WXC9FILE";

        /// <summary>
        /// WXUSER.
        /// </summary>
        public const string WXUSER = "WXUSER";

        /// <summary>
        /// WXPID.
        /// </summary>
        public const string WXPID = "WXPID";

        /// <summary>
        /// WXJOBN.
        /// </summary>
        public const string WXJOBN = "WXJOBN";

        /// <summary>
        /// WXUPMJ.
        /// </summary>
        public const string WXUPMJ = "WXUPMJ";

        /// <summary>
        /// WXTDAY.
        /// </summary>
        public const string WXTDAY = "WXTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WXJOBS", "WXJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WXC9MLNU", "WXC9MLNU", JdeDataType.Numeric, null, true, true),
        new JdeField("WXC9MOSA", "WXC9MOSA", JdeDataType.String, 20, true, true),
        new JdeField("WXC9ITMP", "WXC9ITMP", JdeDataType.Numeric),
        new JdeField("WXC9STRC", "WXC9STRC", JdeDataType.String, 6),
        new JdeField("WXC9LVNO", "WXC9LVNO", JdeDataType.Numeric),
        new JdeField("WXC9LVL0", "WXC9LVL0", JdeDataType.String, 50),
        new JdeField("WXC9LVL1", "WXC9LVL1", JdeDataType.String, 12),
        new JdeField("WXC9LVL2", "WXC9LVL2", JdeDataType.String, 12),
        new JdeField("WXC9LVL3", "WXC9LVL3", JdeDataType.String, 12),
        new JdeField("WXC9LVL4", "WXC9LVL4", JdeDataType.String, 12),
        new JdeField("WXC9LVL5", "WXC9LVL5", JdeDataType.String, 12),
        new JdeField("WXC9LVL6", "WXC9LVL6", JdeDataType.String, 12),
        new JdeField("WXC9LVL7", "WXC9LVL7", JdeDataType.String, 12),
        new JdeField("WXC9LVL8", "WXC9LVL8", JdeDataType.String, 12),
        new JdeField("WXC9LVL9", "WXC9LVL9", JdeDataType.String, 12),
        new JdeField("WXKCOO", "WXKCOO", JdeDataType.String, 10),
        new JdeField("WXDOCO", "WXDOCO", JdeDataType.Numeric),
        new JdeField("WXDCTO", "WXDCTO", JdeDataType.String, 4),
        new JdeField("WXMCU", "WXMCU", JdeDataType.String, 24),
        new JdeField("WXLOCN", "WXLOCN", JdeDataType.String, 40),
        new JdeField("WXLOTN", "WXLOTN", JdeDataType.String, 60),
        new JdeField("WXC9ITMX1", "WXC9ITMX1", JdeDataType.Numeric),
        new JdeField("WXC9ITMX2", "WXC9ITMX2", JdeDataType.Numeric),
        new JdeField("WXC9ITMX3", "WXC9ITMX3", JdeDataType.Numeric),
        new JdeField("WXC9ITMX4", "WXC9ITMX4", JdeDataType.Numeric),
        new JdeField("WXC9ITMX5", "WXC9ITMX5", JdeDataType.Numeric),
        new JdeField("WXC9ITMX6", "WXC9ITMX6", JdeDataType.Numeric),
        new JdeField("WXC9ITMX7", "WXC9ITMX7", JdeDataType.Numeric),
        new JdeField("WXC9ITMX8", "WXC9ITMX8", JdeDataType.Numeric),
        new JdeField("WXC9ITMX9", "WXC9ITMX9", JdeDataType.Numeric),
        new JdeField("WXC9ITMX10", "WXC9ITMX10", JdeDataType.Numeric),
        new JdeField("WXC9ITMX11", "WXC9ITMX11", JdeDataType.Numeric),
        new JdeField("WXC9ITMX12", "WXC9ITMX12", JdeDataType.Numeric),
        new JdeField("WXC9ITMX13", "WXC9ITMX13", JdeDataType.Numeric),
        new JdeField("WXC9ITMX14", "WXC9ITMX14", JdeDataType.Numeric),
        new JdeField("WXC9ITMX15", "WXC9ITMX15", JdeDataType.Numeric),
        new JdeField("WXC9ITMX16", "WXC9ITMX16", JdeDataType.Numeric),
        new JdeField("WXC9ITMX17", "WXC9ITMX17", JdeDataType.Numeric),
        new JdeField("WXC9ITMX18", "WXC9ITMX18", JdeDataType.Numeric),
        new JdeField("WXC9ITMX19", "WXC9ITMX19", JdeDataType.Numeric),
        new JdeField("WXC9ITMX20", "WXC9ITMX20", JdeDataType.Numeric),
        new JdeField("WXC9ITMX21", "WXC9ITMX21", JdeDataType.Numeric),
        new JdeField("WXC9ITMX22", "WXC9ITMX22", JdeDataType.Numeric),
        new JdeField("WXC9ITMX23", "WXC9ITMX23", JdeDataType.Numeric),
        new JdeField("WXC9ITMX24", "WXC9ITMX24", JdeDataType.Numeric),
        new JdeField("WXC9ITMX25", "WXC9ITMX25", JdeDataType.Numeric),
        new JdeField("WXC9ITMX26", "WXC9ITMX26", JdeDataType.Numeric),
        new JdeField("WXC9ITMX27", "WXC9ITMX27", JdeDataType.Numeric),
        new JdeField("WXC9ITMX28", "WXC9ITMX28", JdeDataType.Numeric),
        new JdeField("WXC9ITMX29", "WXC9ITMX29", JdeDataType.Numeric),
        new JdeField("WXC9ITMX30", "WXC9ITMX30", JdeDataType.Numeric),
        new JdeField("WXC9LN1", "WXC9LN1", JdeDataType.Numeric),
        new JdeField("WXC9LN2", "WXC9LN2", JdeDataType.Numeric),
        new JdeField("WXC9LN3", "WXC9LN3", JdeDataType.Numeric),
        new JdeField("WXC9LN4", "WXC9LN4", JdeDataType.Numeric),
        new JdeField("WXC9LN5", "WXC9LN5", JdeDataType.Numeric),
        new JdeField("WXC9LN6", "WXC9LN6", JdeDataType.Numeric),
        new JdeField("WXC9LN7", "WXC9LN7", JdeDataType.Numeric),
        new JdeField("WXC9LN8", "WXC9LN8", JdeDataType.Numeric),
        new JdeField("WXC9LN9", "WXC9LN9", JdeDataType.Numeric),
        new JdeField("WXC9LN10", "WXC9LN10", JdeDataType.Numeric),
        new JdeField("WXC9LN11", "WXC9LN11", JdeDataType.Numeric),
        new JdeField("WXC9LN12", "WXC9LN12", JdeDataType.Numeric),
        new JdeField("WXC9LN13", "WXC9LN13", JdeDataType.Numeric),
        new JdeField("WXC9LN14", "WXC9LN14", JdeDataType.Numeric),
        new JdeField("WXC9LN15", "WXC9LN15", JdeDataType.Numeric),
        new JdeField("WXC9LN16", "WXC9LN16", JdeDataType.Numeric),
        new JdeField("WXC9LN17", "WXC9LN17", JdeDataType.Numeric),
        new JdeField("WXC9LN18", "WXC9LN18", JdeDataType.Numeric),
        new JdeField("WXC9LN19", "WXC9LN19", JdeDataType.Numeric),
        new JdeField("WXC9LN20", "WXC9LN20", JdeDataType.Numeric),
        new JdeField("WXC9LN21", "WXC9LN21", JdeDataType.Numeric),
        new JdeField("WXC9LN22", "WXC9LN22", JdeDataType.Numeric),
        new JdeField("WXC9LN23", "WXC9LN23", JdeDataType.Numeric),
        new JdeField("WXC9LN24", "WXC9LN24", JdeDataType.Numeric),
        new JdeField("WXC9LN25", "WXC9LN25", JdeDataType.Numeric),
        new JdeField("WXC9LN26", "WXC9LN26", JdeDataType.Numeric),
        new JdeField("WXC9LN27", "WXC9LN27", JdeDataType.Numeric),
        new JdeField("WXC9LN28", "WXC9LN28", JdeDataType.Numeric),
        new JdeField("WXC9LN29", "WXC9LN29", JdeDataType.Numeric),
        new JdeField("WXC9LN30", "WXC9LN30", JdeDataType.Numeric),
        new JdeField("WXC9QTY1", "WXC9QTY1", JdeDataType.Numeric),
        new JdeField("WXC9QTY2", "WXC9QTY2", JdeDataType.Numeric),
        new JdeField("WXC9QTY3", "WXC9QTY3", JdeDataType.Numeric),
        new JdeField("WXC9QTY4", "WXC9QTY4", JdeDataType.Numeric),
        new JdeField("WXC9QTY5", "WXC9QTY5", JdeDataType.Numeric),
        new JdeField("WXC9QTY6", "WXC9QTY6", JdeDataType.Numeric),
        new JdeField("WXC9QTY7", "WXC9QTY7", JdeDataType.Numeric),
        new JdeField("WXC9QTY8", "WXC9QTY8", JdeDataType.Numeric),
        new JdeField("WXC9QTY9", "WXC9QTY9", JdeDataType.Numeric),
        new JdeField("WXC9QTY10", "WXC9QTY10", JdeDataType.Numeric),
        new JdeField("WXC9QTY11", "WXC9QTY11", JdeDataType.Numeric),
        new JdeField("WXC9QTY12", "WXC9QTY12", JdeDataType.Numeric),
        new JdeField("WXC9QTY13", "WXC9QTY13", JdeDataType.Numeric),
        new JdeField("WXC9QTY14", "WXC9QTY14", JdeDataType.Numeric),
        new JdeField("WXC9QTY15", "WXC9QTY15", JdeDataType.Numeric),
        new JdeField("WXC9QTY16", "WXC9QTY16", JdeDataType.Numeric),
        new JdeField("WXC9QTY17", "WXC9QTY17", JdeDataType.Numeric),
        new JdeField("WXC9QTY18", "WXC9QTY18", JdeDataType.Numeric),
        new JdeField("WXC9QTY19", "WXC9QTY19", JdeDataType.Numeric),
        new JdeField("WXC9QTY20", "WXC9QTY20", JdeDataType.Numeric),
        new JdeField("WXC9QTY21", "WXC9QTY21", JdeDataType.Numeric),
        new JdeField("WXC9QTY22", "WXC9QTY22", JdeDataType.Numeric),
        new JdeField("WXC9QTY23", "WXC9QTY23", JdeDataType.Numeric),
        new JdeField("WXC9QTY24", "WXC9QTY24", JdeDataType.Numeric),
        new JdeField("WXC9QTY25", "WXC9QTY25", JdeDataType.Numeric),
        new JdeField("WXC9QTY26", "WXC9QTY26", JdeDataType.Numeric),
        new JdeField("WXC9QTY27", "WXC9QTY27", JdeDataType.Numeric),
        new JdeField("WXC9QTY28", "WXC9QTY28", JdeDataType.Numeric),
        new JdeField("WXC9QTY29", "WXC9QTY29", JdeDataType.Numeric),
        new JdeField("WXC9QTY30", "WXC9QTY30", JdeDataType.Numeric),
        new JdeField("WXLTTR", "WXLTTR", JdeDataType.String, 6),
        new JdeField("WXDRQJ", "WXDRQJ", JdeDataType.Numeric),
        new JdeField("WXNXTR", "WXNXTR", JdeDataType.String, 6),
        new JdeField("WXC9FILE", "WXC9FILE", JdeDataType.String, 20),
        new JdeField("WXUSER", "WXUSER", JdeDataType.String, 20),
        new JdeField("WXPID", "WXPID", JdeDataType.String, 20),
        new JdeField("WXJOBN", "WXJOBN", JdeDataType.String, 20),
        new JdeField("WXUPMJ", "WXUPMJ", JdeDataType.Numeric),
        new JdeField("WXTDAY", "WXTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW20_0", "Primary Key on WXJOBS, WXC9MOSA, WXC9MLNU", new[] { "WXJOBS", "WXC9MOSA", "WXC9MLNU" }, isUnique: true, isPrimaryKey: true)
    };
}
