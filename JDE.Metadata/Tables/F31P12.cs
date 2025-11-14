using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31P12 - .
/// </summary>
public class F31P12 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDPRJM.
        /// </summary>
        public const string TDPRJM = "TDPRJM";

        /// <summary>
        /// TDUKID.
        /// </summary>
        public const string TDUKID = "TDUKID";

        /// <summary>
        /// TDPNUM.
        /// </summary>
        public const string TDPNUM = "TDPNUM";

        /// <summary>
        /// TDONUM.
        /// </summary>
        public const string TDONUM = "TDONUM";

        /// <summary>
        /// TDDYTY.
        /// </summary>
        public const string TDDYTY = "TDDYTY";

        /// <summary>
        /// TDLAGT.
        /// </summary>
        public const string TDLAGT = "TDLAGT";

        /// <summary>
        /// TDLAGR.
        /// </summary>
        public const string TDLAGR = "TDLAGR";

        /// <summary>
        /// TDDTX1.
        /// </summary>
        public const string TDDTX1 = "TDDTX1";

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
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

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
    public override string TableName => "F31P12";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDPRJM", "TDPRJM", JdeDataType.Numeric, null, true, true),
        new JdeField("TDUKID", "TDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TDPNUM", "TDPNUM", JdeDataType.Numeric),
        new JdeField("TDONUM", "TDONUM", JdeDataType.Numeric),
        new JdeField("TDDYTY", "TDDYTY", JdeDataType.String, 4),
        new JdeField("TDLAGT", "TDLAGT", JdeDataType.Numeric),
        new JdeField("TDLAGR", "TDLAGR", JdeDataType.String, 2),
        new JdeField("TDDTX1", "TDDTX1", JdeDataType.String, 150),
        new JdeField("TDURCD", "TDURCD", JdeDataType.String, 4),
        new JdeField("TDURDT", "TDURDT", JdeDataType.Numeric),
        new JdeField("TDURAT", "TDURAT", JdeDataType.Numeric),
        new JdeField("TDURAB", "TDURAB", JdeDataType.Numeric),
        new JdeField("TDURRF", "TDURRF", JdeDataType.String, 30),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDTDAY", "TDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31P12_0", "Primary Key on TDPRJM, TDUKID", new[] { "TDPRJM", "TDUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31P12_2", "Index on TDPRJM, TDPNUM", new[] { "TDPRJM", "TDPNUM" }),
        new JdeIndex("F31P12_3", "Index on TDPRJM, TDONUM", new[] { "TDPRJM", "TDONUM" })
    };
}
