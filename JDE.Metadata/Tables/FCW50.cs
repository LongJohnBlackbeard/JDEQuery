using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW50 - .
/// </summary>
public class FCW50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BXKIT.
        /// </summary>
        public const string BXKIT = "BXKIT";

        /// <summary>
        /// BXMMCU.
        /// </summary>
        public const string BXMMCU = "BXMMCU";

        /// <summary>
        /// BXTBM.
        /// </summary>
        public const string BXTBM = "BXTBM";

        /// <summary>
        /// BXBQTY.
        /// </summary>
        public const string BXBQTY = "BXBQTY";

        /// <summary>
        /// BXITM.
        /// </summary>
        public const string BXITM = "BXITM";

        /// <summary>
        /// BXCPNT.
        /// </summary>
        public const string BXCPNT = "BXCPNT";

        /// <summary>
        /// BXSBNT.
        /// </summary>
        public const string BXSBNT = "BXSBNT";

        /// <summary>
        /// BXCOBY.
        /// </summary>
        public const string BXCOBY = "BXCOBY";

        /// <summary>
        /// BXC9LVC0.
        /// </summary>
        public const string BXC9LVC0 = "BXC9LVC0";

        /// <summary>
        /// BXC9LVNO.
        /// </summary>
        public const string BXC9LVNO = "BXC9LVNO";

        /// <summary>
        /// BXC9LVCO1.
        /// </summary>
        public const string BXC9LVCO1 = "BXC9LVCO1";

        /// <summary>
        /// BXC9LVCO2.
        /// </summary>
        public const string BXC9LVCO2 = "BXC9LVCO2";

        /// <summary>
        /// BXC9LVCO3.
        /// </summary>
        public const string BXC9LVCO3 = "BXC9LVCO3";

        /// <summary>
        /// BXC9LVCO4.
        /// </summary>
        public const string BXC9LVCO4 = "BXC9LVCO4";

        /// <summary>
        /// BXC9LVCO5.
        /// </summary>
        public const string BXC9LVCO5 = "BXC9LVCO5";

        /// <summary>
        /// BXC9LVCO6.
        /// </summary>
        public const string BXC9LVCO6 = "BXC9LVCO6";

        /// <summary>
        /// BXC9LVCO7.
        /// </summary>
        public const string BXC9LVCO7 = "BXC9LVCO7";

        /// <summary>
        /// BXC9LVCO8.
        /// </summary>
        public const string BXC9LVCO8 = "BXC9LVCO8";

        /// <summary>
        /// BXC9LVCO9.
        /// </summary>
        public const string BXC9LVCO9 = "BXC9LVCO9";

        /// <summary>
        /// BXC9LVCO10.
        /// </summary>
        public const string BXC9LVCO10 = "BXC9LVCO10";

        /// <summary>
        /// BXC9LVCO11.
        /// </summary>
        public const string BXC9LVCO11 = "BXC9LVCO11";

        /// <summary>
        /// BXC9LVCO12.
        /// </summary>
        public const string BXC9LVCO12 = "BXC9LVCO12";

        /// <summary>
        /// BXC9LVCO13.
        /// </summary>
        public const string BXC9LVCO13 = "BXC9LVCO13";

        /// <summary>
        /// BXC9LVCO14.
        /// </summary>
        public const string BXC9LVCO14 = "BXC9LVCO14";

        /// <summary>
        /// BXC9LVCO15.
        /// </summary>
        public const string BXC9LVCO15 = "BXC9LVCO15";

        /// <summary>
        /// BXC9LVCO16.
        /// </summary>
        public const string BXC9LVCO16 = "BXC9LVCO16";

        /// <summary>
        /// BXC9LVCO17.
        /// </summary>
        public const string BXC9LVCO17 = "BXC9LVCO17";

        /// <summary>
        /// BXC9LVCO18.
        /// </summary>
        public const string BXC9LVCO18 = "BXC9LVCO18";

        /// <summary>
        /// BXC9LVCO19.
        /// </summary>
        public const string BXC9LVCO19 = "BXC9LVCO19";

        /// <summary>
        /// BXC9LVCO20.
        /// </summary>
        public const string BXC9LVCO20 = "BXC9LVCO20";

        /// <summary>
        /// BXC9LVCO21.
        /// </summary>
        public const string BXC9LVCO21 = "BXC9LVCO21";

        /// <summary>
        /// BXC9LVCO22.
        /// </summary>
        public const string BXC9LVCO22 = "BXC9LVCO22";

        /// <summary>
        /// BXC9LVCO23.
        /// </summary>
        public const string BXC9LVCO23 = "BXC9LVCO23";

        /// <summary>
        /// BXC9LVCO24.
        /// </summary>
        public const string BXC9LVCO24 = "BXC9LVCO24";

        /// <summary>
        /// BXC9LVCO25.
        /// </summary>
        public const string BXC9LVCO25 = "BXC9LVCO25";

        /// <summary>
        /// BXC9LVCO26.
        /// </summary>
        public const string BXC9LVCO26 = "BXC9LVCO26";

        /// <summary>
        /// BXC9LVCO27.
        /// </summary>
        public const string BXC9LVCO27 = "BXC9LVCO27";

        /// <summary>
        /// BXC9LVCO28.
        /// </summary>
        public const string BXC9LVCO28 = "BXC9LVCO28";

        /// <summary>
        /// BXC9LVCO29.
        /// </summary>
        public const string BXC9LVCO29 = "BXC9LVCO29";

        /// <summary>
        /// BXC9LVCO30.
        /// </summary>
        public const string BXC9LVCO30 = "BXC9LVCO30";

        /// <summary>
        /// BXC9STRC.
        /// </summary>
        public const string BXC9STRC = "BXC9STRC";

        /// <summary>
        /// BXC9GRCD.
        /// </summary>
        public const string BXC9GRCD = "BXC9GRCD";

        /// <summary>
        /// BXCPNB.
        /// </summary>
        public const string BXCPNB = "BXCPNB";

        /// <summary>
        /// BXCOQNTY1.
        /// </summary>
        public const string BXCOQNTY1 = "BXCOQNTY1";

        /// <summary>
        /// BXCOQNTY2.
        /// </summary>
        public const string BXCOQNTY2 = "BXCOQNTY2";

        /// <summary>
        /// BXCOQNTY3.
        /// </summary>
        public const string BXCOQNTY3 = "BXCOQNTY3";

        /// <summary>
        /// BXCOQNTY4.
        /// </summary>
        public const string BXCOQNTY4 = "BXCOQNTY4";

        /// <summary>
        /// BXCOQNTY5.
        /// </summary>
        public const string BXCOQNTY5 = "BXCOQNTY5";

        /// <summary>
        /// BXCOQNTY6.
        /// </summary>
        public const string BXCOQNTY6 = "BXCOQNTY6";

        /// <summary>
        /// BXCOQNTY7.
        /// </summary>
        public const string BXCOQNTY7 = "BXCOQNTY7";

        /// <summary>
        /// BXCOQNTY8.
        /// </summary>
        public const string BXCOQNTY8 = "BXCOQNTY8";

        /// <summary>
        /// BXCOQNTY9.
        /// </summary>
        public const string BXCOQNTY9 = "BXCOQNTY9";

        /// <summary>
        /// BXCOQNTY10.
        /// </summary>
        public const string BXCOQNTY10 = "BXCOQNTY10";

        /// <summary>
        /// BXCOQNTY11.
        /// </summary>
        public const string BXCOQNTY11 = "BXCOQNTY11";

        /// <summary>
        /// BXCOQNTY12.
        /// </summary>
        public const string BXCOQNTY12 = "BXCOQNTY12";

        /// <summary>
        /// BXCOQNTY13.
        /// </summary>
        public const string BXCOQNTY13 = "BXCOQNTY13";

        /// <summary>
        /// BXCOQNTY14.
        /// </summary>
        public const string BXCOQNTY14 = "BXCOQNTY14";

        /// <summary>
        /// BXCOQNTY15.
        /// </summary>
        public const string BXCOQNTY15 = "BXCOQNTY15";

        /// <summary>
        /// BXCOQNTY16.
        /// </summary>
        public const string BXCOQNTY16 = "BXCOQNTY16";

        /// <summary>
        /// BXCOQNTY18.
        /// </summary>
        public const string BXCOQNTY18 = "BXCOQNTY18";

        /// <summary>
        /// BXCOQNTY17.
        /// </summary>
        public const string BXCOQNTY17 = "BXCOQNTY17";

        /// <summary>
        /// BXCOQNTY19.
        /// </summary>
        public const string BXCOQNTY19 = "BXCOQNTY19";

        /// <summary>
        /// BXCOQNTY20.
        /// </summary>
        public const string BXCOQNTY20 = "BXCOQNTY20";

        /// <summary>
        /// BXCOQNTY21.
        /// </summary>
        public const string BXCOQNTY21 = "BXCOQNTY21";

        /// <summary>
        /// BXCOQNTY22.
        /// </summary>
        public const string BXCOQNTY22 = "BXCOQNTY22";

        /// <summary>
        /// BXCOQNTY23.
        /// </summary>
        public const string BXCOQNTY23 = "BXCOQNTY23";

        /// <summary>
        /// BXCOQNTY24.
        /// </summary>
        public const string BXCOQNTY24 = "BXCOQNTY24";

        /// <summary>
        /// BXCOQNTY25.
        /// </summary>
        public const string BXCOQNTY25 = "BXCOQNTY25";

        /// <summary>
        /// BXCOQNTY26.
        /// </summary>
        public const string BXCOQNTY26 = "BXCOQNTY26";

        /// <summary>
        /// BXCOQNTY27.
        /// </summary>
        public const string BXCOQNTY27 = "BXCOQNTY27";

        /// <summary>
        /// BXCOQNTY28.
        /// </summary>
        public const string BXCOQNTY28 = "BXCOQNTY28";

        /// <summary>
        /// BXCOQNTY29.
        /// </summary>
        public const string BXCOQNTY29 = "BXCOQNTY29";

        /// <summary>
        /// BXCOQNTY30.
        /// </summary>
        public const string BXCOQNTY30 = "BXCOQNTY30";
    }

    /// <inheritdoc />
    public override string TableName => "FCW50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BXKIT", "BXKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("BXMMCU", "BXMMCU", JdeDataType.String, 24, true, true),
        new JdeField("BXTBM", "BXTBM", JdeDataType.String, 6, true, true),
        new JdeField("BXBQTY", "BXBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("BXITM", "BXITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BXCPNT", "BXCPNT", JdeDataType.Numeric),
        new JdeField("BXSBNT", "BXSBNT", JdeDataType.Numeric, null, true, true),
        new JdeField("BXCOBY", "BXCOBY", JdeDataType.String, 2, true, true),
        new JdeField("BXC9LVC0", "BXC9LVC0", JdeDataType.String, 50, true, true),
        new JdeField("BXC9LVNO", "BXC9LVNO", JdeDataType.Numeric),
        new JdeField("BXC9LVCO1", "BXC9LVCO1", JdeDataType.String, 50),
        new JdeField("BXC9LVCO2", "BXC9LVCO2", JdeDataType.String, 50),
        new JdeField("BXC9LVCO3", "BXC9LVCO3", JdeDataType.String, 50),
        new JdeField("BXC9LVCO4", "BXC9LVCO4", JdeDataType.String, 50),
        new JdeField("BXC9LVCO5", "BXC9LVCO5", JdeDataType.String, 50),
        new JdeField("BXC9LVCO6", "BXC9LVCO6", JdeDataType.String, 50),
        new JdeField("BXC9LVCO7", "BXC9LVCO7", JdeDataType.String, 50),
        new JdeField("BXC9LVCO8", "BXC9LVCO8", JdeDataType.String, 50),
        new JdeField("BXC9LVCO9", "BXC9LVCO9", JdeDataType.String, 50),
        new JdeField("BXC9LVCO10", "BXC9LVCO10", JdeDataType.String, 50),
        new JdeField("BXC9LVCO11", "BXC9LVCO11", JdeDataType.String, 50),
        new JdeField("BXC9LVCO12", "BXC9LVCO12", JdeDataType.String, 50),
        new JdeField("BXC9LVCO13", "BXC9LVCO13", JdeDataType.String, 50),
        new JdeField("BXC9LVCO14", "BXC9LVCO14", JdeDataType.String, 50),
        new JdeField("BXC9LVCO15", "BXC9LVCO15", JdeDataType.String, 50),
        new JdeField("BXC9LVCO16", "BXC9LVCO16", JdeDataType.String, 50),
        new JdeField("BXC9LVCO17", "BXC9LVCO17", JdeDataType.String, 50),
        new JdeField("BXC9LVCO18", "BXC9LVCO18", JdeDataType.String, 50),
        new JdeField("BXC9LVCO19", "BXC9LVCO19", JdeDataType.String, 50),
        new JdeField("BXC9LVCO20", "BXC9LVCO20", JdeDataType.String, 50),
        new JdeField("BXC9LVCO21", "BXC9LVCO21", JdeDataType.String, 50),
        new JdeField("BXC9LVCO22", "BXC9LVCO22", JdeDataType.String, 50),
        new JdeField("BXC9LVCO23", "BXC9LVCO23", JdeDataType.String, 50),
        new JdeField("BXC9LVCO24", "BXC9LVCO24", JdeDataType.String, 50),
        new JdeField("BXC9LVCO25", "BXC9LVCO25", JdeDataType.String, 50),
        new JdeField("BXC9LVCO26", "BXC9LVCO26", JdeDataType.String, 50),
        new JdeField("BXC9LVCO27", "BXC9LVCO27", JdeDataType.String, 50),
        new JdeField("BXC9LVCO28", "BXC9LVCO28", JdeDataType.String, 50),
        new JdeField("BXC9LVCO29", "BXC9LVCO29", JdeDataType.String, 50),
        new JdeField("BXC9LVCO30", "BXC9LVCO30", JdeDataType.String, 50),
        new JdeField("BXC9STRC", "BXC9STRC", JdeDataType.String, 6),
        new JdeField("BXC9GRCD", "BXC9GRCD", JdeDataType.String, 6),
        new JdeField("BXCPNB", "BXCPNB", JdeDataType.Numeric, null, true, true),
        new JdeField("BXCOQNTY1", "BXCOQNTY1", JdeDataType.Numeric),
        new JdeField("BXCOQNTY2", "BXCOQNTY2", JdeDataType.Numeric),
        new JdeField("BXCOQNTY3", "BXCOQNTY3", JdeDataType.Numeric),
        new JdeField("BXCOQNTY4", "BXCOQNTY4", JdeDataType.Numeric),
        new JdeField("BXCOQNTY5", "BXCOQNTY5", JdeDataType.Numeric),
        new JdeField("BXCOQNTY6", "BXCOQNTY6", JdeDataType.Numeric),
        new JdeField("BXCOQNTY7", "BXCOQNTY7", JdeDataType.Numeric),
        new JdeField("BXCOQNTY8", "BXCOQNTY8", JdeDataType.Numeric),
        new JdeField("BXCOQNTY9", "BXCOQNTY9", JdeDataType.Numeric),
        new JdeField("BXCOQNTY10", "BXCOQNTY10", JdeDataType.Numeric),
        new JdeField("BXCOQNTY11", "BXCOQNTY11", JdeDataType.Numeric),
        new JdeField("BXCOQNTY12", "BXCOQNTY12", JdeDataType.Numeric),
        new JdeField("BXCOQNTY13", "BXCOQNTY13", JdeDataType.Numeric),
        new JdeField("BXCOQNTY14", "BXCOQNTY14", JdeDataType.Numeric),
        new JdeField("BXCOQNTY15", "BXCOQNTY15", JdeDataType.Numeric),
        new JdeField("BXCOQNTY16", "BXCOQNTY16", JdeDataType.Numeric),
        new JdeField("BXCOQNTY18", "BXCOQNTY18", JdeDataType.Numeric),
        new JdeField("BXCOQNTY17", "BXCOQNTY17", JdeDataType.Numeric),
        new JdeField("BXCOQNTY19", "BXCOQNTY19", JdeDataType.Numeric),
        new JdeField("BXCOQNTY20", "BXCOQNTY20", JdeDataType.Numeric),
        new JdeField("BXCOQNTY21", "BXCOQNTY21", JdeDataType.Numeric),
        new JdeField("BXCOQNTY22", "BXCOQNTY22", JdeDataType.Numeric),
        new JdeField("BXCOQNTY23", "BXCOQNTY23", JdeDataType.Numeric),
        new JdeField("BXCOQNTY24", "BXCOQNTY24", JdeDataType.Numeric),
        new JdeField("BXCOQNTY25", "BXCOQNTY25", JdeDataType.Numeric),
        new JdeField("BXCOQNTY26", "BXCOQNTY26", JdeDataType.Numeric),
        new JdeField("BXCOQNTY27", "BXCOQNTY27", JdeDataType.Numeric),
        new JdeField("BXCOQNTY28", "BXCOQNTY28", JdeDataType.Numeric),
        new JdeField("BXCOQNTY29", "BXCOQNTY29", JdeDataType.Numeric),
        new JdeField("BXCOQNTY30", "BXCOQNTY30", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW50_0", "Primary Key on BXKIT, BXMMCU, BXTBM, BXBQTY, BXITM, BXCPNB, BXSBNT, BXCOBY, BXC9LVC0", new[] { "BXKIT", "BXMMCU", "BXTBM", "BXBQTY", "BXITM", "BXCPNB", "BXSBNT", "BXCOBY", "BXC9LVC0" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW50_3", "Index on BXKIT, BXMMCU, BXTBM, BXBQTY, BXITM", new[] { "BXKIT", "BXMMCU", "BXTBM", "BXBQTY", "BXITM" })
    };
}
