using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49634 - .
/// </summary>
public class F49634 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QDSHPN.
        /// </summary>
        public const string QDSHPN = "QDSHPN";

        /// <summary>
        /// QDDOCO.
        /// </summary>
        public const string QDDOCO = "QDDOCO";

        /// <summary>
        /// QDDCTO.
        /// </summary>
        public const string QDDCTO = "QDDCTO";

        /// <summary>
        /// QDKCOO.
        /// </summary>
        public const string QDKCOO = "QDKCOO";

        /// <summary>
        /// QDLNID.
        /// </summary>
        public const string QDLNID = "QDLNID";

        /// <summary>
        /// QDWGTS.
        /// </summary>
        public const string QDWGTS = "QDWGTS";

        /// <summary>
        /// QDWTUM.
        /// </summary>
        public const string QDWTUM = "QDWTUM";

        /// <summary>
        /// QDSCVL.
        /// </summary>
        public const string QDSCVL = "QDSCVL";

        /// <summary>
        /// QDVLUM.
        /// </summary>
        public const string QDVLUM = "QDVLUM";

        /// <summary>
        /// QDSOQS.
        /// </summary>
        public const string QDSOQS = "QDSOQS";

        /// <summary>
        /// QDUOM.
        /// </summary>
        public const string QDUOM = "QDUOM";

        /// <summary>
        /// QDNMFC.
        /// </summary>
        public const string QDNMFC = "QDNMFC";

        /// <summary>
        /// QDDSGP.
        /// </summary>
        public const string QDDSGP = "QDDSGP";

        /// <summary>
        /// QDFRT1.
        /// </summary>
        public const string QDFRT1 = "QDFRT1";

        /// <summary>
        /// QDFRT2.
        /// </summary>
        public const string QDFRT2 = "QDFRT2";

        /// <summary>
        /// QDECST.
        /// </summary>
        public const string QDECST = "QDECST";

        /// <summary>
        /// QDAEXP.
        /// </summary>
        public const string QDAEXP = "QDAEXP";

        /// <summary>
        /// QDFEA.
        /// </summary>
        public const string QDFEA = "QDFEA";

        /// <summary>
        /// QDCRCD.
        /// </summary>
        public const string QDCRCD = "QDCRCD";

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
        /// QDURAB.
        /// </summary>
        public const string QDURAB = "QDURAB";

        /// <summary>
        /// QDURRF.
        /// </summary>
        public const string QDURRF = "QDURRF";

        /// <summary>
        /// QDUSER.
        /// </summary>
        public const string QDUSER = "QDUSER";

        /// <summary>
        /// QDPID.
        /// </summary>
        public const string QDPID = "QDPID";

        /// <summary>
        /// QDJOBN.
        /// </summary>
        public const string QDJOBN = "QDJOBN";

        /// <summary>
        /// QDUPMJ.
        /// </summary>
        public const string QDUPMJ = "QDUPMJ";

        /// <summary>
        /// QDTDAY.
        /// </summary>
        public const string QDTDAY = "QDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49634";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QDSHPN", "QDSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("QDDOCO", "QDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("QDDCTO", "QDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("QDKCOO", "QDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("QDLNID", "QDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("QDWGTS", "QDWGTS", JdeDataType.Numeric),
        new JdeField("QDWTUM", "QDWTUM", JdeDataType.String, 4),
        new JdeField("QDSCVL", "QDSCVL", JdeDataType.Numeric),
        new JdeField("QDVLUM", "QDVLUM", JdeDataType.String, 4),
        new JdeField("QDSOQS", "QDSOQS", JdeDataType.Numeric),
        new JdeField("QDUOM", "QDUOM", JdeDataType.String, 4),
        new JdeField("QDNMFC", "QDNMFC", JdeDataType.String, 8),
        new JdeField("QDDSGP", "QDDSGP", JdeDataType.String, 6),
        new JdeField("QDFRT1", "QDFRT1", JdeDataType.String, 12),
        new JdeField("QDFRT2", "QDFRT2", JdeDataType.String, 12),
        new JdeField("QDECST", "QDECST", JdeDataType.Numeric),
        new JdeField("QDAEXP", "QDAEXP", JdeDataType.Numeric),
        new JdeField("QDFEA", "QDFEA", JdeDataType.Numeric),
        new JdeField("QDCRCD", "QDCRCD", JdeDataType.String, 6),
        new JdeField("QDURCD", "QDURCD", JdeDataType.String, 4),
        new JdeField("QDURDT", "QDURDT", JdeDataType.Numeric),
        new JdeField("QDURAT", "QDURAT", JdeDataType.Numeric),
        new JdeField("QDURAB", "QDURAB", JdeDataType.Numeric),
        new JdeField("QDURRF", "QDURRF", JdeDataType.String, 30),
        new JdeField("QDUSER", "QDUSER", JdeDataType.String, 20),
        new JdeField("QDPID", "QDPID", JdeDataType.String, 20),
        new JdeField("QDJOBN", "QDJOBN", JdeDataType.String, 20),
        new JdeField("QDUPMJ", "QDUPMJ", JdeDataType.Numeric),
        new JdeField("QDTDAY", "QDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49634_0", "Primary Key on QDSHPN, QDDOCO, QDDCTO, QDKCOO, QDLNID", new[] { "QDSHPN", "QDDOCO", "QDDCTO", "QDKCOO", "QDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
