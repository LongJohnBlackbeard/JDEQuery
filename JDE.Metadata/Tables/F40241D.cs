using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40241D - .
/// </summary>
public class F40241D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAUNSPSC.
        /// </summary>
        public const string CAUNSPSC = "CAUNSPSC";

        /// <summary>
        /// CALNGP.
        /// </summary>
        public const string CALNGP = "CALNGP";

        /// <summary>
        /// CAUNSPSCDS1.
        /// </summary>
        public const string CAUNSPSCDS1 = "CAUNSPSCDS1";

        /// <summary>
        /// CASRTX.
        /// </summary>
        public const string CASRTX = "CASRTX";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAJOBN.
        /// </summary>
        public const string CAJOBN = "CAJOBN";

        /// <summary>
        /// CAUPMJ.
        /// </summary>
        public const string CAUPMJ = "CAUPMJ";

        /// <summary>
        /// CATDAY.
        /// </summary>
        public const string CATDAY = "CATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40241D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAUNSPSC", "CAUNSPSC", JdeDataType.String, 16, true, true),
        new JdeField("CALNGP", "CALNGP", JdeDataType.String, 4, true, true),
        new JdeField("CAUNSPSCDS1", "CAUNSPSCDS1", JdeDataType.String, 80),
        new JdeField("CASRTX", "CASRTX", JdeDataType.String, 60),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAJOBN", "CAJOBN", JdeDataType.String, 20),
        new JdeField("CAUPMJ", "CAUPMJ", JdeDataType.Numeric),
        new JdeField("CATDAY", "CATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40241D_0", "Primary Key on CAUNSPSC, CALNGP", new[] { "CAUNSPSC", "CALNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
