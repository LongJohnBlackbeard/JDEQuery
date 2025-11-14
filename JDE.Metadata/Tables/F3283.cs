using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3283 - .
/// </summary>
public class F3283 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDRTBT.
        /// </summary>
        public const string RDRTBT = "RDRTBT";

        /// <summary>
        /// RDTBLC.
        /// </summary>
        public const string RDTBLC = "RDTBLC";

        /// <summary>
        /// RDMCU.
        /// </summary>
        public const string RDMCU = "RDMCU";

        /// <summary>
        /// RDCTKID.
        /// </summary>
        public const string RDCTKID = "RDCTKID";

        /// <summary>
        /// RDTSV1.
        /// </summary>
        public const string RDTSV1 = "RDTSV1";

        /// <summary>
        /// RDTSV2.
        /// </summary>
        public const string RDTSV2 = "RDTSV2";

        /// <summary>
        /// RDTSV3.
        /// </summary>
        public const string RDTSV3 = "RDTSV3";

        /// <summary>
        /// RDTSV4.
        /// </summary>
        public const string RDTSV4 = "RDTSV4";

        /// <summary>
        /// RDTSV5.
        /// </summary>
        public const string RDTSV5 = "RDTSV5";

        /// <summary>
        /// RDTSV6.
        /// </summary>
        public const string RDTSV6 = "RDTSV6";

        /// <summary>
        /// RDTSV7.
        /// </summary>
        public const string RDTSV7 = "RDTSV7";

        /// <summary>
        /// RDTSV8.
        /// </summary>
        public const string RDTSV8 = "RDTSV8";

        /// <summary>
        /// RDTSV9.
        /// </summary>
        public const string RDTSV9 = "RDTSV9";

        /// <summary>
        /// RDTSV0.
        /// </summary>
        public const string RDTSV0 = "RDTSV0";

        /// <summary>
        /// RDTSV11.
        /// </summary>
        public const string RDTSV11 = "RDTSV11";

        /// <summary>
        /// RDTSV12.
        /// </summary>
        public const string RDTSV12 = "RDTSV12";

        /// <summary>
        /// RDTSV13.
        /// </summary>
        public const string RDTSV13 = "RDTSV13";

        /// <summary>
        /// RDTSV14.
        /// </summary>
        public const string RDTSV14 = "RDTSV14";

        /// <summary>
        /// RDTSV15.
        /// </summary>
        public const string RDTSV15 = "RDTSV15";

        /// <summary>
        /// RDTSV16.
        /// </summary>
        public const string RDTSV16 = "RDTSV16";

        /// <summary>
        /// RDTSV17.
        /// </summary>
        public const string RDTSV17 = "RDTSV17";

        /// <summary>
        /// RDTSV18.
        /// </summary>
        public const string RDTSV18 = "RDTSV18";

        /// <summary>
        /// RDTSV19.
        /// </summary>
        public const string RDTSV19 = "RDTSV19";

        /// <summary>
        /// RDTSV20.
        /// </summary>
        public const string RDTSV20 = "RDTSV20";

        /// <summary>
        /// RDBSEQ.
        /// </summary>
        public const string RDBSEQ = "RDBSEQ";

        /// <summary>
        /// RDEFFF.
        /// </summary>
        public const string RDEFFF = "RDEFFF";

        /// <summary>
        /// RDEFFT.
        /// </summary>
        public const string RDEFFT = "RDEFFT";

        /// <summary>
        /// RDTVAL.
        /// </summary>
        public const string RDTVAL = "RDTVAL";

        /// <summary>
        /// RDUPAX.
        /// </summary>
        public const string RDUPAX = "RDUPAX";

        /// <summary>
        /// RDITM.
        /// </summary>
        public const string RDITM = "RDITM";

        /// <summary>
        /// RDQNTY.
        /// </summary>
        public const string RDQNTY = "RDQNTY";

        /// <summary>
        /// RDUM.
        /// </summary>
        public const string RDUM = "RDUM";

        /// <summary>
        /// RDURCD.
        /// </summary>
        public const string RDURCD = "RDURCD";

        /// <summary>
        /// RDURDT.
        /// </summary>
        public const string RDURDT = "RDURDT";

        /// <summary>
        /// RDURAT.
        /// </summary>
        public const string RDURAT = "RDURAT";

        /// <summary>
        /// RDURAB.
        /// </summary>
        public const string RDURAB = "RDURAB";

        /// <summary>
        /// RDURRF.
        /// </summary>
        public const string RDURRF = "RDURRF";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDTDAY.
        /// </summary>
        public const string RDTDAY = "RDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3283";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDRTBT", "RDRTBT", JdeDataType.String, 2, true, true),
        new JdeField("RDTBLC", "RDTBLC", JdeDataType.String, 20, true, true),
        new JdeField("RDMCU", "RDMCU", JdeDataType.String, 24, true, true),
        new JdeField("RDCTKID", "RDCTKID", JdeDataType.String, 64, true, true),
        new JdeField("RDTSV1", "RDTSV1", JdeDataType.String, 80),
        new JdeField("RDTSV2", "RDTSV2", JdeDataType.String, 80),
        new JdeField("RDTSV3", "RDTSV3", JdeDataType.String, 80),
        new JdeField("RDTSV4", "RDTSV4", JdeDataType.String, 80),
        new JdeField("RDTSV5", "RDTSV5", JdeDataType.String, 80),
        new JdeField("RDTSV6", "RDTSV6", JdeDataType.String, 80),
        new JdeField("RDTSV7", "RDTSV7", JdeDataType.String, 80),
        new JdeField("RDTSV8", "RDTSV8", JdeDataType.String, 80),
        new JdeField("RDTSV9", "RDTSV9", JdeDataType.String, 80),
        new JdeField("RDTSV0", "RDTSV0", JdeDataType.String, 80),
        new JdeField("RDTSV11", "RDTSV11", JdeDataType.String, 80),
        new JdeField("RDTSV12", "RDTSV12", JdeDataType.String, 80),
        new JdeField("RDTSV13", "RDTSV13", JdeDataType.String, 80),
        new JdeField("RDTSV14", "RDTSV14", JdeDataType.String, 80),
        new JdeField("RDTSV15", "RDTSV15", JdeDataType.String, 80),
        new JdeField("RDTSV16", "RDTSV16", JdeDataType.String, 80),
        new JdeField("RDTSV17", "RDTSV17", JdeDataType.String, 80),
        new JdeField("RDTSV18", "RDTSV18", JdeDataType.String, 80),
        new JdeField("RDTSV19", "RDTSV19", JdeDataType.String, 80),
        new JdeField("RDTSV20", "RDTSV20", JdeDataType.String, 80),
        new JdeField("RDBSEQ", "RDBSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RDEFFF", "RDEFFF", JdeDataType.Numeric),
        new JdeField("RDEFFT", "RDEFFT", JdeDataType.Numeric),
        new JdeField("RDTVAL", "RDTVAL", JdeDataType.String, 80),
        new JdeField("RDUPAX", "RDUPAX", JdeDataType.Numeric),
        new JdeField("RDITM", "RDITM", JdeDataType.Numeric),
        new JdeField("RDQNTY", "RDQNTY", JdeDataType.Numeric),
        new JdeField("RDUM", "RDUM", JdeDataType.String, 4),
        new JdeField("RDURCD", "RDURCD", JdeDataType.String, 4),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDURRF", "RDURRF", JdeDataType.String, 30),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDTDAY", "RDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3283_0", "Primary Key on RDTBLC, RDMCU, RDRTBT, RDCTKID, RDBSEQ", new[] { "RDTBLC", "RDMCU", "RDRTBT", "RDCTKID", "RDBSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3283_4", "Index on RDMCU, RDRTBT, RDTVAL, RDITM, RDTBLC", new[] { "RDMCU", "RDRTBT", "RDTVAL", "RDITM", "RDTBLC" })
    };
}
