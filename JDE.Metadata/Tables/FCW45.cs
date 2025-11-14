using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW45 - .
/// </summary>
public class FCW45 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OLJOBS.
        /// </summary>
        public const string OLJOBS = "OLJOBS";

        /// <summary>
        /// OLUSER.
        /// </summary>
        public const string OLUSER = "OLUSER";

        /// <summary>
        /// OLKCOO.
        /// </summary>
        public const string OLKCOO = "OLKCOO";

        /// <summary>
        /// OLDOCO.
        /// </summary>
        public const string OLDOCO = "OLDOCO";

        /// <summary>
        /// OLDCTO.
        /// </summary>
        public const string OLDCTO = "OLDCTO";

        /// <summary>
        /// OLC9MLNU.
        /// </summary>
        public const string OLC9MLNU = "OLC9MLNU";

        /// <summary>
        /// OLC9ITMP.
        /// </summary>
        public const string OLC9ITMP = "OLC9ITMP";

        /// <summary>
        /// OLMCU.
        /// </summary>
        public const string OLMCU = "OLMCU";

        /// <summary>
        /// OLLOCN.
        /// </summary>
        public const string OLLOCN = "OLLOCN";

        /// <summary>
        /// OLLOTN.
        /// </summary>
        public const string OLLOTN = "OLLOTN";

        /// <summary>
        /// OLRECOPT.
        /// </summary>
        public const string OLRECOPT = "OLRECOPT";

        /// <summary>
        /// OLC9STRC.
        /// </summary>
        public const string OLC9STRC = "OLC9STRC";

        /// <summary>
        /// OLC9LVNO.
        /// </summary>
        public const string OLC9LVNO = "OLC9LVNO";

        /// <summary>
        /// OLC9LVL0.
        /// </summary>
        public const string OLC9LVL0 = "OLC9LVL0";

        /// <summary>
        /// OLC9LVL1.
        /// </summary>
        public const string OLC9LVL1 = "OLC9LVL1";

        /// <summary>
        /// OLC9LVL2.
        /// </summary>
        public const string OLC9LVL2 = "OLC9LVL2";

        /// <summary>
        /// OLC9LVL3.
        /// </summary>
        public const string OLC9LVL3 = "OLC9LVL3";

        /// <summary>
        /// OLC9LVL4.
        /// </summary>
        public const string OLC9LVL4 = "OLC9LVL4";

        /// <summary>
        /// OLC9LVL5.
        /// </summary>
        public const string OLC9LVL5 = "OLC9LVL5";

        /// <summary>
        /// OLC9LVL6.
        /// </summary>
        public const string OLC9LVL6 = "OLC9LVL6";

        /// <summary>
        /// OLC9LVL7.
        /// </summary>
        public const string OLC9LVL7 = "OLC9LVL7";

        /// <summary>
        /// OLC9LVL8.
        /// </summary>
        public const string OLC9LVL8 = "OLC9LVL8";

        /// <summary>
        /// OLC9LVL9.
        /// </summary>
        public const string OLC9LVL9 = "OLC9LVL9";

        /// <summary>
        /// OLC9ITMX1.
        /// </summary>
        public const string OLC9ITMX1 = "OLC9ITMX1";

        /// <summary>
        /// OLC9ITMX2.
        /// </summary>
        public const string OLC9ITMX2 = "OLC9ITMX2";

        /// <summary>
        /// OLC9ITMX3.
        /// </summary>
        public const string OLC9ITMX3 = "OLC9ITMX3";

        /// <summary>
        /// OLC9ITMX4.
        /// </summary>
        public const string OLC9ITMX4 = "OLC9ITMX4";

        /// <summary>
        /// OLC9ITMX5.
        /// </summary>
        public const string OLC9ITMX5 = "OLC9ITMX5";

        /// <summary>
        /// OLC9ITMX6.
        /// </summary>
        public const string OLC9ITMX6 = "OLC9ITMX6";

        /// <summary>
        /// OLC9ITMX7.
        /// </summary>
        public const string OLC9ITMX7 = "OLC9ITMX7";

        /// <summary>
        /// OLC9ITMX8.
        /// </summary>
        public const string OLC9ITMX8 = "OLC9ITMX8";

        /// <summary>
        /// OLC9ITMX9.
        /// </summary>
        public const string OLC9ITMX9 = "OLC9ITMX9";

        /// <summary>
        /// OLC9ITMX10.
        /// </summary>
        public const string OLC9ITMX10 = "OLC9ITMX10";

        /// <summary>
        /// OLC9ITMX11.
        /// </summary>
        public const string OLC9ITMX11 = "OLC9ITMX11";

        /// <summary>
        /// OLC9ITMX12.
        /// </summary>
        public const string OLC9ITMX12 = "OLC9ITMX12";

        /// <summary>
        /// OLC9ITMX13.
        /// </summary>
        public const string OLC9ITMX13 = "OLC9ITMX13";

        /// <summary>
        /// OLC9ITMX14.
        /// </summary>
        public const string OLC9ITMX14 = "OLC9ITMX14";

        /// <summary>
        /// OLC9ITMX15.
        /// </summary>
        public const string OLC9ITMX15 = "OLC9ITMX15";

        /// <summary>
        /// OLC9ITMX16.
        /// </summary>
        public const string OLC9ITMX16 = "OLC9ITMX16";

        /// <summary>
        /// OLC9ITMX17.
        /// </summary>
        public const string OLC9ITMX17 = "OLC9ITMX17";

        /// <summary>
        /// OLC9ITMX18.
        /// </summary>
        public const string OLC9ITMX18 = "OLC9ITMX18";

        /// <summary>
        /// OLC9ITMX19.
        /// </summary>
        public const string OLC9ITMX19 = "OLC9ITMX19";

        /// <summary>
        /// OLC9ITMX20.
        /// </summary>
        public const string OLC9ITMX20 = "OLC9ITMX20";

        /// <summary>
        /// OLC9ITMX21.
        /// </summary>
        public const string OLC9ITMX21 = "OLC9ITMX21";

        /// <summary>
        /// OLC9ITMX22.
        /// </summary>
        public const string OLC9ITMX22 = "OLC9ITMX22";

        /// <summary>
        /// OLC9ITMX23.
        /// </summary>
        public const string OLC9ITMX23 = "OLC9ITMX23";

        /// <summary>
        /// OLC9ITMX24.
        /// </summary>
        public const string OLC9ITMX24 = "OLC9ITMX24";

        /// <summary>
        /// OLC9ITMX25.
        /// </summary>
        public const string OLC9ITMX25 = "OLC9ITMX25";

        /// <summary>
        /// OLC9ITMX26.
        /// </summary>
        public const string OLC9ITMX26 = "OLC9ITMX26";

        /// <summary>
        /// OLC9ITMX27.
        /// </summary>
        public const string OLC9ITMX27 = "OLC9ITMX27";

        /// <summary>
        /// OLC9ITMX28.
        /// </summary>
        public const string OLC9ITMX28 = "OLC9ITMX28";

        /// <summary>
        /// OLC9ITMX29.
        /// </summary>
        public const string OLC9ITMX29 = "OLC9ITMX29";

        /// <summary>
        /// OLC9ITMX30.
        /// </summary>
        public const string OLC9ITMX30 = "OLC9ITMX30";

        /// <summary>
        /// OLC9LN1.
        /// </summary>
        public const string OLC9LN1 = "OLC9LN1";

        /// <summary>
        /// OLC9LN2.
        /// </summary>
        public const string OLC9LN2 = "OLC9LN2";

        /// <summary>
        /// OLC9LN3.
        /// </summary>
        public const string OLC9LN3 = "OLC9LN3";

        /// <summary>
        /// OLC9LN4.
        /// </summary>
        public const string OLC9LN4 = "OLC9LN4";

        /// <summary>
        /// OLC9LN5.
        /// </summary>
        public const string OLC9LN5 = "OLC9LN5";

        /// <summary>
        /// OLC9LN6.
        /// </summary>
        public const string OLC9LN6 = "OLC9LN6";

        /// <summary>
        /// OLC9LN7.
        /// </summary>
        public const string OLC9LN7 = "OLC9LN7";

        /// <summary>
        /// OLC9LN8.
        /// </summary>
        public const string OLC9LN8 = "OLC9LN8";

        /// <summary>
        /// OLC9LN9.
        /// </summary>
        public const string OLC9LN9 = "OLC9LN9";

        /// <summary>
        /// OLC9LN10.
        /// </summary>
        public const string OLC9LN10 = "OLC9LN10";

        /// <summary>
        /// OLC9LN11.
        /// </summary>
        public const string OLC9LN11 = "OLC9LN11";

        /// <summary>
        /// OLC9LN12.
        /// </summary>
        public const string OLC9LN12 = "OLC9LN12";

        /// <summary>
        /// OLC9LN13.
        /// </summary>
        public const string OLC9LN13 = "OLC9LN13";

        /// <summary>
        /// OLC9LN14.
        /// </summary>
        public const string OLC9LN14 = "OLC9LN14";

        /// <summary>
        /// OLC9LN15.
        /// </summary>
        public const string OLC9LN15 = "OLC9LN15";

        /// <summary>
        /// OLC9LN16.
        /// </summary>
        public const string OLC9LN16 = "OLC9LN16";

        /// <summary>
        /// OLC9LN17.
        /// </summary>
        public const string OLC9LN17 = "OLC9LN17";

        /// <summary>
        /// OLC9LN18.
        /// </summary>
        public const string OLC9LN18 = "OLC9LN18";

        /// <summary>
        /// OLC9LN19.
        /// </summary>
        public const string OLC9LN19 = "OLC9LN19";

        /// <summary>
        /// OLC9LN20.
        /// </summary>
        public const string OLC9LN20 = "OLC9LN20";

        /// <summary>
        /// OLC9LN21.
        /// </summary>
        public const string OLC9LN21 = "OLC9LN21";

        /// <summary>
        /// OLC9LN22.
        /// </summary>
        public const string OLC9LN22 = "OLC9LN22";

        /// <summary>
        /// OLC9LN23.
        /// </summary>
        public const string OLC9LN23 = "OLC9LN23";

        /// <summary>
        /// OLC9LN24.
        /// </summary>
        public const string OLC9LN24 = "OLC9LN24";

        /// <summary>
        /// OLC9LN25.
        /// </summary>
        public const string OLC9LN25 = "OLC9LN25";

        /// <summary>
        /// OLC9LN26.
        /// </summary>
        public const string OLC9LN26 = "OLC9LN26";

        /// <summary>
        /// OLC9LN27.
        /// </summary>
        public const string OLC9LN27 = "OLC9LN27";

        /// <summary>
        /// OLC9LN28.
        /// </summary>
        public const string OLC9LN28 = "OLC9LN28";

        /// <summary>
        /// OLC9LN29.
        /// </summary>
        public const string OLC9LN29 = "OLC9LN29";

        /// <summary>
        /// OLC9LN30.
        /// </summary>
        public const string OLC9LN30 = "OLC9LN30";

        /// <summary>
        /// OLC9QTY1.
        /// </summary>
        public const string OLC9QTY1 = "OLC9QTY1";

        /// <summary>
        /// OLC9QTY2.
        /// </summary>
        public const string OLC9QTY2 = "OLC9QTY2";

        /// <summary>
        /// OLC9QTY3.
        /// </summary>
        public const string OLC9QTY3 = "OLC9QTY3";

        /// <summary>
        /// OLC9QTY4.
        /// </summary>
        public const string OLC9QTY4 = "OLC9QTY4";

        /// <summary>
        /// OLC9QTY5.
        /// </summary>
        public const string OLC9QTY5 = "OLC9QTY5";

        /// <summary>
        /// OLC9QTY6.
        /// </summary>
        public const string OLC9QTY6 = "OLC9QTY6";

        /// <summary>
        /// OLC9QTY7.
        /// </summary>
        public const string OLC9QTY7 = "OLC9QTY7";

        /// <summary>
        /// OLC9QTY8.
        /// </summary>
        public const string OLC9QTY8 = "OLC9QTY8";

        /// <summary>
        /// OLC9QTY9.
        /// </summary>
        public const string OLC9QTY9 = "OLC9QTY9";

        /// <summary>
        /// OLC9QTY10.
        /// </summary>
        public const string OLC9QTY10 = "OLC9QTY10";

        /// <summary>
        /// OLC9QTY11.
        /// </summary>
        public const string OLC9QTY11 = "OLC9QTY11";

        /// <summary>
        /// OLC9QTY12.
        /// </summary>
        public const string OLC9QTY12 = "OLC9QTY12";

        /// <summary>
        /// OLC9QTY13.
        /// </summary>
        public const string OLC9QTY13 = "OLC9QTY13";

        /// <summary>
        /// OLC9QTY14.
        /// </summary>
        public const string OLC9QTY14 = "OLC9QTY14";

        /// <summary>
        /// OLC9QTY15.
        /// </summary>
        public const string OLC9QTY15 = "OLC9QTY15";

        /// <summary>
        /// OLC9QTY16.
        /// </summary>
        public const string OLC9QTY16 = "OLC9QTY16";

        /// <summary>
        /// OLC9QTY17.
        /// </summary>
        public const string OLC9QTY17 = "OLC9QTY17";

        /// <summary>
        /// OLC9QTY18.
        /// </summary>
        public const string OLC9QTY18 = "OLC9QTY18";

        /// <summary>
        /// OLC9QTY19.
        /// </summary>
        public const string OLC9QTY19 = "OLC9QTY19";

        /// <summary>
        /// OLC9QTY20.
        /// </summary>
        public const string OLC9QTY20 = "OLC9QTY20";

        /// <summary>
        /// OLC9QTY21.
        /// </summary>
        public const string OLC9QTY21 = "OLC9QTY21";

        /// <summary>
        /// OLC9QTY22.
        /// </summary>
        public const string OLC9QTY22 = "OLC9QTY22";

        /// <summary>
        /// OLC9QTY23.
        /// </summary>
        public const string OLC9QTY23 = "OLC9QTY23";

        /// <summary>
        /// OLC9QTY24.
        /// </summary>
        public const string OLC9QTY24 = "OLC9QTY24";

        /// <summary>
        /// OLC9QTY25.
        /// </summary>
        public const string OLC9QTY25 = "OLC9QTY25";

        /// <summary>
        /// OLC9QTY26.
        /// </summary>
        public const string OLC9QTY26 = "OLC9QTY26";

        /// <summary>
        /// OLC9QTY27.
        /// </summary>
        public const string OLC9QTY27 = "OLC9QTY27";

        /// <summary>
        /// OLC9QTY28.
        /// </summary>
        public const string OLC9QTY28 = "OLC9QTY28";

        /// <summary>
        /// OLC9QTY29.
        /// </summary>
        public const string OLC9QTY29 = "OLC9QTY29";

        /// <summary>
        /// OLC9QTY30.
        /// </summary>
        public const string OLC9QTY30 = "OLC9QTY30";
    }

    /// <inheritdoc />
    public override string TableName => "FCW45";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OLJOBS", "OLJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("OLUSER", "OLUSER", JdeDataType.String, 20, true, true),
        new JdeField("OLKCOO", "OLKCOO", JdeDataType.String, 10, true, true),
        new JdeField("OLDOCO", "OLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OLDCTO", "OLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("OLC9MLNU", "OLC9MLNU", JdeDataType.Numeric, null, true, true),
        new JdeField("OLC9ITMP", "OLC9ITMP", JdeDataType.Numeric, null, true, true),
        new JdeField("OLMCU", "OLMCU", JdeDataType.String, 24, true, true),
        new JdeField("OLLOCN", "OLLOCN", JdeDataType.String, 40, true, true),
        new JdeField("OLLOTN", "OLLOTN", JdeDataType.String, 60, true, true),
        new JdeField("OLRECOPT", "OLRECOPT", JdeDataType.String, 2, true, true),
        new JdeField("OLC9STRC", "OLC9STRC", JdeDataType.String, 6),
        new JdeField("OLC9LVNO", "OLC9LVNO", JdeDataType.Numeric),
        new JdeField("OLC9LVL0", "OLC9LVL0", JdeDataType.String, 50),
        new JdeField("OLC9LVL1", "OLC9LVL1", JdeDataType.String, 12),
        new JdeField("OLC9LVL2", "OLC9LVL2", JdeDataType.String, 12),
        new JdeField("OLC9LVL3", "OLC9LVL3", JdeDataType.String, 12),
        new JdeField("OLC9LVL4", "OLC9LVL4", JdeDataType.String, 12),
        new JdeField("OLC9LVL5", "OLC9LVL5", JdeDataType.String, 12),
        new JdeField("OLC9LVL6", "OLC9LVL6", JdeDataType.String, 12),
        new JdeField("OLC9LVL7", "OLC9LVL7", JdeDataType.String, 12),
        new JdeField("OLC9LVL8", "OLC9LVL8", JdeDataType.String, 12),
        new JdeField("OLC9LVL9", "OLC9LVL9", JdeDataType.String, 12),
        new JdeField("OLC9ITMX1", "OLC9ITMX1", JdeDataType.Numeric),
        new JdeField("OLC9ITMX2", "OLC9ITMX2", JdeDataType.Numeric),
        new JdeField("OLC9ITMX3", "OLC9ITMX3", JdeDataType.Numeric),
        new JdeField("OLC9ITMX4", "OLC9ITMX4", JdeDataType.Numeric),
        new JdeField("OLC9ITMX5", "OLC9ITMX5", JdeDataType.Numeric),
        new JdeField("OLC9ITMX6", "OLC9ITMX6", JdeDataType.Numeric),
        new JdeField("OLC9ITMX7", "OLC9ITMX7", JdeDataType.Numeric),
        new JdeField("OLC9ITMX8", "OLC9ITMX8", JdeDataType.Numeric),
        new JdeField("OLC9ITMX9", "OLC9ITMX9", JdeDataType.Numeric),
        new JdeField("OLC9ITMX10", "OLC9ITMX10", JdeDataType.Numeric),
        new JdeField("OLC9ITMX11", "OLC9ITMX11", JdeDataType.Numeric),
        new JdeField("OLC9ITMX12", "OLC9ITMX12", JdeDataType.Numeric),
        new JdeField("OLC9ITMX13", "OLC9ITMX13", JdeDataType.Numeric),
        new JdeField("OLC9ITMX14", "OLC9ITMX14", JdeDataType.Numeric),
        new JdeField("OLC9ITMX15", "OLC9ITMX15", JdeDataType.Numeric),
        new JdeField("OLC9ITMX16", "OLC9ITMX16", JdeDataType.Numeric),
        new JdeField("OLC9ITMX17", "OLC9ITMX17", JdeDataType.Numeric),
        new JdeField("OLC9ITMX18", "OLC9ITMX18", JdeDataType.Numeric),
        new JdeField("OLC9ITMX19", "OLC9ITMX19", JdeDataType.Numeric),
        new JdeField("OLC9ITMX20", "OLC9ITMX20", JdeDataType.Numeric),
        new JdeField("OLC9ITMX21", "OLC9ITMX21", JdeDataType.Numeric),
        new JdeField("OLC9ITMX22", "OLC9ITMX22", JdeDataType.Numeric),
        new JdeField("OLC9ITMX23", "OLC9ITMX23", JdeDataType.Numeric),
        new JdeField("OLC9ITMX24", "OLC9ITMX24", JdeDataType.Numeric),
        new JdeField("OLC9ITMX25", "OLC9ITMX25", JdeDataType.Numeric),
        new JdeField("OLC9ITMX26", "OLC9ITMX26", JdeDataType.Numeric),
        new JdeField("OLC9ITMX27", "OLC9ITMX27", JdeDataType.Numeric),
        new JdeField("OLC9ITMX28", "OLC9ITMX28", JdeDataType.Numeric),
        new JdeField("OLC9ITMX29", "OLC9ITMX29", JdeDataType.Numeric),
        new JdeField("OLC9ITMX30", "OLC9ITMX30", JdeDataType.Numeric),
        new JdeField("OLC9LN1", "OLC9LN1", JdeDataType.Numeric),
        new JdeField("OLC9LN2", "OLC9LN2", JdeDataType.Numeric),
        new JdeField("OLC9LN3", "OLC9LN3", JdeDataType.Numeric),
        new JdeField("OLC9LN4", "OLC9LN4", JdeDataType.Numeric),
        new JdeField("OLC9LN5", "OLC9LN5", JdeDataType.Numeric),
        new JdeField("OLC9LN6", "OLC9LN6", JdeDataType.Numeric),
        new JdeField("OLC9LN7", "OLC9LN7", JdeDataType.Numeric),
        new JdeField("OLC9LN8", "OLC9LN8", JdeDataType.Numeric),
        new JdeField("OLC9LN9", "OLC9LN9", JdeDataType.Numeric),
        new JdeField("OLC9LN10", "OLC9LN10", JdeDataType.Numeric),
        new JdeField("OLC9LN11", "OLC9LN11", JdeDataType.Numeric),
        new JdeField("OLC9LN12", "OLC9LN12", JdeDataType.Numeric),
        new JdeField("OLC9LN13", "OLC9LN13", JdeDataType.Numeric),
        new JdeField("OLC9LN14", "OLC9LN14", JdeDataType.Numeric),
        new JdeField("OLC9LN15", "OLC9LN15", JdeDataType.Numeric),
        new JdeField("OLC9LN16", "OLC9LN16", JdeDataType.Numeric),
        new JdeField("OLC9LN17", "OLC9LN17", JdeDataType.Numeric),
        new JdeField("OLC9LN18", "OLC9LN18", JdeDataType.Numeric),
        new JdeField("OLC9LN19", "OLC9LN19", JdeDataType.Numeric),
        new JdeField("OLC9LN20", "OLC9LN20", JdeDataType.Numeric),
        new JdeField("OLC9LN21", "OLC9LN21", JdeDataType.Numeric),
        new JdeField("OLC9LN22", "OLC9LN22", JdeDataType.Numeric),
        new JdeField("OLC9LN23", "OLC9LN23", JdeDataType.Numeric),
        new JdeField("OLC9LN24", "OLC9LN24", JdeDataType.Numeric),
        new JdeField("OLC9LN25", "OLC9LN25", JdeDataType.Numeric),
        new JdeField("OLC9LN26", "OLC9LN26", JdeDataType.Numeric),
        new JdeField("OLC9LN27", "OLC9LN27", JdeDataType.Numeric),
        new JdeField("OLC9LN28", "OLC9LN28", JdeDataType.Numeric),
        new JdeField("OLC9LN29", "OLC9LN29", JdeDataType.Numeric),
        new JdeField("OLC9LN30", "OLC9LN30", JdeDataType.Numeric),
        new JdeField("OLC9QTY1", "OLC9QTY1", JdeDataType.Numeric),
        new JdeField("OLC9QTY2", "OLC9QTY2", JdeDataType.Numeric),
        new JdeField("OLC9QTY3", "OLC9QTY3", JdeDataType.Numeric),
        new JdeField("OLC9QTY4", "OLC9QTY4", JdeDataType.Numeric),
        new JdeField("OLC9QTY5", "OLC9QTY5", JdeDataType.Numeric),
        new JdeField("OLC9QTY6", "OLC9QTY6", JdeDataType.Numeric),
        new JdeField("OLC9QTY7", "OLC9QTY7", JdeDataType.Numeric),
        new JdeField("OLC9QTY8", "OLC9QTY8", JdeDataType.Numeric),
        new JdeField("OLC9QTY9", "OLC9QTY9", JdeDataType.Numeric),
        new JdeField("OLC9QTY10", "OLC9QTY10", JdeDataType.Numeric),
        new JdeField("OLC9QTY11", "OLC9QTY11", JdeDataType.Numeric),
        new JdeField("OLC9QTY12", "OLC9QTY12", JdeDataType.Numeric),
        new JdeField("OLC9QTY13", "OLC9QTY13", JdeDataType.Numeric),
        new JdeField("OLC9QTY14", "OLC9QTY14", JdeDataType.Numeric),
        new JdeField("OLC9QTY15", "OLC9QTY15", JdeDataType.Numeric),
        new JdeField("OLC9QTY16", "OLC9QTY16", JdeDataType.Numeric),
        new JdeField("OLC9QTY17", "OLC9QTY17", JdeDataType.Numeric),
        new JdeField("OLC9QTY18", "OLC9QTY18", JdeDataType.Numeric),
        new JdeField("OLC9QTY19", "OLC9QTY19", JdeDataType.Numeric),
        new JdeField("OLC9QTY20", "OLC9QTY20", JdeDataType.Numeric),
        new JdeField("OLC9QTY21", "OLC9QTY21", JdeDataType.Numeric),
        new JdeField("OLC9QTY22", "OLC9QTY22", JdeDataType.Numeric),
        new JdeField("OLC9QTY23", "OLC9QTY23", JdeDataType.Numeric),
        new JdeField("OLC9QTY24", "OLC9QTY24", JdeDataType.Numeric),
        new JdeField("OLC9QTY25", "OLC9QTY25", JdeDataType.Numeric),
        new JdeField("OLC9QTY26", "OLC9QTY26", JdeDataType.Numeric),
        new JdeField("OLC9QTY27", "OLC9QTY27", JdeDataType.Numeric),
        new JdeField("OLC9QTY28", "OLC9QTY28", JdeDataType.Numeric),
        new JdeField("OLC9QTY29", "OLC9QTY29", JdeDataType.Numeric),
        new JdeField("OLC9QTY30", "OLC9QTY30", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW45_0", "Primary Key on OLJOBS, OLUSER, OLKCOO, OLDOCO, OLDCTO, OLC9MLNU, OLC9ITMP, OLMCU, OLLOCN, OLLOTN, OLRECOPT", new[] { "OLJOBS", "OLUSER", "OLKCOO", "OLDOCO", "OLDCTO", "OLC9MLNU", "OLC9ITMP", "OLMCU", "OLLOCN", "OLLOTN", "OLRECOPT" }, isUnique: true, isPrimaryKey: true)
    };
}
