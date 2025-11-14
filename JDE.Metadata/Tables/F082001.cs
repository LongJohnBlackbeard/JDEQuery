using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F082001 - .
/// </summary>
public class F082001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HSPGRD.
        /// </summary>
        public const string HSPGRD = "HSPGRD";

        /// <summary>
        /// HSPGRS.
        /// </summary>
        public const string HSPGRS = "HSPGRS";

        /// <summary>
        /// HSAAQ1.
        /// </summary>
        public const string HSAAQ1 = "HSAAQ1";

        /// <summary>
        /// HSAAQ2.
        /// </summary>
        public const string HSAAQ2 = "HSAAQ2";

        /// <summary>
        /// HSAAQ3.
        /// </summary>
        public const string HSAAQ3 = "HSAAQ3";

        /// <summary>
        /// HSAAQ4.
        /// </summary>
        public const string HSAAQ4 = "HSAAQ4";

        /// <summary>
        /// HSAAQ5.
        /// </summary>
        public const string HSAAQ5 = "HSAAQ5";

        /// <summary>
        /// HSRMK.
        /// </summary>
        public const string HSRMK = "HSRMK";

        /// <summary>
        /// HSSALY.
        /// </summary>
        public const string HSSALY = "HSSALY";

        /// <summary>
        /// HSSR.
        /// </summary>
        public const string HSSR = "HSSR";

        /// <summary>
        /// HSUSER.
        /// </summary>
        public const string HSUSER = "HSUSER";

        /// <summary>
        /// HSPID.
        /// </summary>
        public const string HSPID = "HSPID";

        /// <summary>
        /// HSUPMJ.
        /// </summary>
        public const string HSUPMJ = "HSUPMJ";

        /// <summary>
        /// HSJOBN.
        /// </summary>
        public const string HSJOBN = "HSJOBN";

        /// <summary>
        /// HSSLOC.
        /// </summary>
        public const string HSSLOC = "HSSLOC";

        /// <summary>
        /// HSDEF.
        /// </summary>
        public const string HSDEF = "HSDEF";

        /// <summary>
        /// HSNPGD.
        /// </summary>
        public const string HSNPGD = "HSNPGD";

        /// <summary>
        /// HSNPGS.
        /// </summary>
        public const string HSNPGS = "HSNPGS";

        /// <summary>
        /// HSPGSR.
        /// </summary>
        public const string HSPGSR = "HSPGSR";

        /// <summary>
        /// HSSTDD.
        /// </summary>
        public const string HSSTDD = "HSSTDD";

        /// <summary>
        /// HSSDYY.
        /// </summary>
        public const string HSSDYY = "HSSDYY";

        /// <summary>
        /// HSIH.
        /// </summary>
        public const string HSIH = "HSIH";

        /// <summary>
        /// HSUN.
        /// </summary>
        public const string HSUN = "HSUN";

        /// <summary>
        /// HSPSTP.
        /// </summary>
        public const string HSPSTP = "HSPSTP";

        /// <summary>
        /// HSSTAA.
        /// </summary>
        public const string HSSTAA = "HSSTAA";

        /// <summary>
        /// HSRNGP.
        /// </summary>
        public const string HSRNGP = "HSRNGP";
    }

    /// <inheritdoc />
    public override string TableName => "F082001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HSPGRD", "HSPGRD", JdeDataType.String, 12, true, true),
        new JdeField("HSPGRS", "HSPGRS", JdeDataType.String, 8, true, true),
        new JdeField("HSAAQ1", "HSAAQ1", JdeDataType.Numeric),
        new JdeField("HSAAQ2", "HSAAQ2", JdeDataType.Numeric),
        new JdeField("HSAAQ3", "HSAAQ3", JdeDataType.Numeric),
        new JdeField("HSAAQ4", "HSAAQ4", JdeDataType.Numeric),
        new JdeField("HSAAQ5", "HSAAQ5", JdeDataType.Numeric),
        new JdeField("HSRMK", "HSRMK", JdeDataType.String, 60),
        new JdeField("HSSALY", "HSSALY", JdeDataType.String, 2, true, true),
        new JdeField("HSSR", "HSSR", JdeDataType.String, 4),
        new JdeField("HSUSER", "HSUSER", JdeDataType.String, 20),
        new JdeField("HSPID", "HSPID", JdeDataType.String, 20),
        new JdeField("HSUPMJ", "HSUPMJ", JdeDataType.Numeric),
        new JdeField("HSJOBN", "HSJOBN", JdeDataType.String, 20),
        new JdeField("HSSLOC", "HSSLOC", JdeDataType.String, 16, true, true),
        new JdeField("HSDEF", "HSDEF", JdeDataType.Numeric, null, true, true),
        new JdeField("HSNPGD", "HSNPGD", JdeDataType.String, 12),
        new JdeField("HSNPGS", "HSNPGS", JdeDataType.String, 8),
        new JdeField("HSPGSR", "HSPGSR", JdeDataType.Numeric),
        new JdeField("HSSTDD", "HSSTDD", JdeDataType.Numeric),
        new JdeField("HSSDYY", "HSSDYY", JdeDataType.Numeric),
        new JdeField("HSIH", "HSIH", JdeDataType.Numeric),
        new JdeField("HSUN", "HSUN", JdeDataType.String, 12, true, true),
        new JdeField("HSPSTP", "HSPSTP", JdeDataType.String, 8),
        new JdeField("HSSTAA", "HSSTAA", JdeDataType.Numeric),
        new JdeField("HSRNGP", "HSRNGP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F082001_0", "Primary Key on HSSALY, HSSLOC, HSDEF, HSUN, HSPGRD, HSPGRS", new[] { "HSSALY", "HSSLOC", "HSDEF", "HSUN", "HSPGRD", "HSPGRS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F082001_10", "Index on HSSALY, HSSR, HSSLOC, HSUN, SYS_NC00027$, HSPGRD, HSPGRS", new[] { "HSSALY", "HSSR", "HSSLOC", "HSUN", "SYS_NC00027$", "HSPGRD", "HSPGRS" }),
        new JdeIndex("F082001_11", "Index on HSSALY, HSSR, HSUN, SYS_NC00027$, HSPGRD, HSPGRS, HSSLOC", new[] { "HSSALY", "HSSR", "HSUN", "SYS_NC00027$", "HSPGRD", "HSPGRS", "HSSLOC" }),
        new JdeIndex("F082001_12", "Index on HSSALY, HSPGRD, SYS_NC00027$, HSSLOC, HSUN, HSPGRS", new[] { "HSSALY", "HSPGRD", "SYS_NC00027$", "HSSLOC", "HSUN", "HSPGRS" }),
        new JdeIndex("F082001_13", "Index on HSSALY, HSUN, HSPGRD, SYS_NC00027$, HSSLOC, HSPGRS", new[] { "HSSALY", "HSUN", "HSPGRD", "SYS_NC00027$", "HSSLOC", "HSPGRS" }),
        new JdeIndex("F082001_14", "Index on HSSALY, HSPGRD, HSPGRS, HSUN, HSSLOC, SYS_NC00027$", new[] { "HSSALY", "HSPGRD", "HSPGRS", "HSUN", "HSSLOC", "SYS_NC00027$" }),
        new JdeIndex("F082001_15", "Index on HSSALY, HSPGRD, HSPGRS, HSSLOC, HSUN, SYS_NC00027$", new[] { "HSSALY", "HSPGRD", "HSPGRS", "HSSLOC", "HSUN", "SYS_NC00027$" }),
        new JdeIndex("F082001_2", "Unique Index on HSSALY, SYS_NC00027$, HSPGRD, HSSLOC, HSUN, HSPGRS", new[] { "HSSALY", "SYS_NC00027$", "HSPGRD", "HSSLOC", "HSUN", "HSPGRS" }, isUnique: true),
        new JdeIndex("F082001_3", "Index on HSSALY, HSSLOC, HSPGRD, SYS_NC00027$", new[] { "HSSALY", "HSSLOC", "HSPGRD", "SYS_NC00027$" }),
        new JdeIndex("F082001_4", "Unique Index on HSSALY, HSSLOC, HSPGRD, SYS_NC00027$, HSUN, HSPGRS", new[] { "HSSALY", "HSSLOC", "HSPGRD", "SYS_NC00027$", "HSUN", "HSPGRS" }, isUnique: true),
        new JdeIndex("F082001_5", "Unique Index on HSSALY, HSSR, HSSLOC, SYS_NC00027$, HSPGRD, HSUN, HSPGRS", new[] { "HSSALY", "HSSR", "HSSLOC", "SYS_NC00027$", "HSPGRD", "HSUN", "HSPGRS" }, isUnique: true),
        new JdeIndex("F082001_6", "Unique Index on HSSALY, HSSR, SYS_NC00027$, HSPGRD, HSSLOC, HSPGRS, HSUN", new[] { "HSSALY", "HSSR", "SYS_NC00027$", "HSPGRD", "HSSLOC", "HSPGRS", "HSUN" }, isUnique: true),
        new JdeIndex("F082001_7", "Index on HSSALY, HSSLOC, HSUN, HSPGRD, SYS_NC00027$, HSPGRS", new[] { "HSSALY", "HSSLOC", "HSUN", "HSPGRD", "SYS_NC00027$", "HSPGRS" }),
        new JdeIndex("F082001_8", "Index on HSSALY, HSSLOC, HSUN, SYS_NC00027$, HSPGRD, HSPGRS", new[] { "HSSALY", "HSSLOC", "HSUN", "SYS_NC00027$", "HSPGRD", "HSPGRS" }),
        new JdeIndex("F082001_9", "Index on HSSALY, HSUN, SYS_NC00027$, HSPGRD, HSPGRS, HSSLOC", new[] { "HSSALY", "HSUN", "SYS_NC00027$", "HSPGRD", "HSPGRS", "HSSLOC" })
    };
}
