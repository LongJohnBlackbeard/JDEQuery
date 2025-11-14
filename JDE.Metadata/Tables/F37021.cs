using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F37021 - .
/// </summary>
public class F37021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QDQSPC.
        /// </summary>
        public const string QDQSPC = "QDQSPC";

        /// <summary>
        /// QDMCU.
        /// </summary>
        public const string QDMCU = "QDMCU";

        /// <summary>
        /// QDSTAW.
        /// </summary>
        public const string QDSTAW = "QDSTAW";

        /// <summary>
        /// QDEFFF.
        /// </summary>
        public const string QDEFFF = "QDEFFF";

        /// <summary>
        /// QDEFFT.
        /// </summary>
        public const string QDEFFT = "QDEFFT";

        /// <summary>
        /// QDQTSN.
        /// </summary>
        public const string QDQTSN = "QDQTSN";

        /// <summary>
        /// QDTSRT.
        /// </summary>
        public const string QDTSRT = "QDTSRT";

        /// <summary>
        /// QDQTST.
        /// </summary>
        public const string QDQTST = "QDQTST";

        /// <summary>
        /// QDMCU2.
        /// </summary>
        public const string QDMCU2 = "QDMCU2";

        /// <summary>
        /// QDURCD.
        /// </summary>
        public const string QDURCD = "QDURCD";

        /// <summary>
        /// QDURDT.
        /// </summary>
        public const string QDURDT = "QDURDT";

        /// <summary>
        /// QDURAT.
        /// </summary>
        public const string QDURAT = "QDURAT";

        /// <summary>
        /// QDURRF.
        /// </summary>
        public const string QDURRF = "QDURRF";

        /// <summary>
        /// QDURAB.
        /// </summary>
        public const string QDURAB = "QDURAB";

        /// <summary>
        /// QDUKID.
        /// </summary>
        public const string QDUKID = "QDUKID";

        /// <summary>
        /// QDACTN.
        /// </summary>
        public const string QDACTN = "QDACTN";

        /// <summary>
        /// QDUSER.
        /// </summary>
        public const string QDUSER = "QDUSER";

        /// <summary>
        /// QDPID.
        /// </summary>
        public const string QDPID = "QDPID";

        /// <summary>
        /// QDUPMJ.
        /// </summary>
        public const string QDUPMJ = "QDUPMJ";

        /// <summary>
        /// QDTDAY.
        /// </summary>
        public const string QDTDAY = "QDTDAY";

        /// <summary>
        /// QDJOBN.
        /// </summary>
        public const string QDJOBN = "QDJOBN";

        /// <summary>
        /// QDQMRF2.
        /// </summary>
        public const string QDQMRF2 = "QDQMRF2";

        /// <summary>
        /// QDQMCD2.
        /// </summary>
        public const string QDQMCD2 = "QDQMCD2";

        /// <summary>
        /// QDQMAB2.
        /// </summary>
        public const string QDQMAB2 = "QDQMAB2";

        /// <summary>
        /// QDQMNUM2.
        /// </summary>
        public const string QDQMNUM2 = "QDQMNUM2";

        /// <summary>
        /// QDQMDT2.
        /// </summary>
        public const string QDQMDT2 = "QDQMDT2";
    }

    /// <inheritdoc />
    public override string TableName => "F37021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QDQSPC", "QDQSPC", JdeDataType.String, 50, true, true),
        new JdeField("QDMCU", "QDMCU", JdeDataType.String, 24, true, true),
        new JdeField("QDSTAW", "QDSTAW", JdeDataType.String, 2, true, true),
        new JdeField("QDEFFF", "QDEFFF", JdeDataType.Numeric),
        new JdeField("QDEFFT", "QDEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("QDQTSN", "QDQTSN", JdeDataType.Numeric, null, true, true),
        new JdeField("QDTSRT", "QDTSRT", JdeDataType.Numeric, null, true, true),
        new JdeField("QDQTST", "QDQTST", JdeDataType.String, 50),
        new JdeField("QDMCU2", "QDMCU2", JdeDataType.String, 24),
        new JdeField("QDURCD", "QDURCD", JdeDataType.String, 4),
        new JdeField("QDURDT", "QDURDT", JdeDataType.Numeric),
        new JdeField("QDURAT", "QDURAT", JdeDataType.Numeric),
        new JdeField("QDURRF", "QDURRF", JdeDataType.String, 30),
        new JdeField("QDURAB", "QDURAB", JdeDataType.Numeric),
        new JdeField("QDUKID", "QDUKID", JdeDataType.Numeric),
        new JdeField("QDACTN", "QDACTN", JdeDataType.String, 2),
        new JdeField("QDUSER", "QDUSER", JdeDataType.String, 20),
        new JdeField("QDPID", "QDPID", JdeDataType.String, 20),
        new JdeField("QDUPMJ", "QDUPMJ", JdeDataType.Numeric),
        new JdeField("QDTDAY", "QDTDAY", JdeDataType.Numeric),
        new JdeField("QDJOBN", "QDJOBN", JdeDataType.String, 20),
        new JdeField("QDQMRF2", "QDQMRF2", JdeDataType.String, 60),
        new JdeField("QDQMCD2", "QDQMCD2", JdeDataType.String, 6),
        new JdeField("QDQMAB2", "QDQMAB2", JdeDataType.Numeric),
        new JdeField("QDQMNUM2", "QDQMNUM2", JdeDataType.Numeric),
        new JdeField("QDQMDT2", "QDQMDT2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F37021_0", "Primary Key on QDQSPC, QDMCU, QDSTAW, QDEFFT, QDQTSN, QDTSRT", new[] { "QDQSPC", "QDMCU", "QDSTAW", "QDEFFT", "QDQTSN", "QDTSRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F37021_2", "Index on QDQTST, QDMCU2, QDSTAW", new[] { "QDQTST", "QDMCU2", "QDSTAW" }),
        new JdeIndex("F37021_5", "Index on QDQSPC, QDMCU, QDSTAW, QDUKID", new[] { "QDQSPC", "QDMCU", "QDSTAW", "QDUKID" }),
        new JdeIndex("F37021_6", "Index on QDQSPC, QDMCU, QDSTAW, QDTSRT", new[] { "QDQSPC", "QDMCU", "QDSTAW", "QDTSRT" })
    };
}
