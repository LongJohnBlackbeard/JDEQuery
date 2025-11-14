using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49612 - .
/// </summary>
public class F49612 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDVMCU.
        /// </summary>
        public const string TDVMCU = "TDVMCU";

        /// <summary>
        /// TDLDNM.
        /// </summary>
        public const string TDLDNM = "TDLDNM";

        /// <summary>
        /// TDOSEQ.
        /// </summary>
        public const string TDOSEQ = "TDOSEQ";

        /// <summary>
        /// TDVEHI.
        /// </summary>
        public const string TDVEHI = "TDVEHI";

        /// <summary>
        /// TDRLNO.
        /// </summary>
        public const string TDRLNO = "TDRLNO";

        /// <summary>
        /// TDVTYP.
        /// </summary>
        public const string TDVTYP = "TDVTYP";

        /// <summary>
        /// TDDUMV.
        /// </summary>
        public const string TDDUMV = "TDDUMV";

        /// <summary>
        /// TDNCE.
        /// </summary>
        public const string TDNCE = "TDNCE";

        /// <summary>
        /// TDURCD.
        /// </summary>
        public const string TDURCD = "TDURCD";

        /// <summary>
        /// TDURDT.
        /// </summary>
        public const string TDURDT = "TDURDT";

        /// <summary>
        /// TDURAT.
        /// </summary>
        public const string TDURAT = "TDURAT";

        /// <summary>
        /// TDURAB.
        /// </summary>
        public const string TDURAB = "TDURAB";

        /// <summary>
        /// TDURRF.
        /// </summary>
        public const string TDURRF = "TDURRF";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDTDAY.
        /// </summary>
        public const string TDTDAY = "TDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49612";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDVMCU", "TDVMCU", JdeDataType.String, 24, true, true),
        new JdeField("TDLDNM", "TDLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("TDOSEQ", "TDOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("TDVEHI", "TDVEHI", JdeDataType.String, 24),
        new JdeField("TDRLNO", "TDRLNO", JdeDataType.String, 26),
        new JdeField("TDVTYP", "TDVTYP", JdeDataType.String, 24),
        new JdeField("TDDUMV", "TDDUMV", JdeDataType.String, 2),
        new JdeField("TDNCE", "TDNCE", JdeDataType.Numeric),
        new JdeField("TDURCD", "TDURCD", JdeDataType.String, 4),
        new JdeField("TDURDT", "TDURDT", JdeDataType.Numeric),
        new JdeField("TDURAT", "TDURAT", JdeDataType.Numeric),
        new JdeField("TDURAB", "TDURAB", JdeDataType.Numeric),
        new JdeField("TDURRF", "TDURRF", JdeDataType.String, 30),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDTDAY", "TDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49612_0", "Primary Key on TDVMCU, TDLDNM, TDOSEQ", new[] { "TDVMCU", "TDLDNM", "TDOSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49612_2", "Index on TDVMCU, TDLDNM, TDVEHI, TDRLNO", new[] { "TDVMCU", "TDLDNM", "TDVEHI", "TDRLNO" })
    };
}
