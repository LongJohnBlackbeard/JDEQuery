using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A73 - .
/// </summary>
public class F79A73 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OC79AGCID.
        /// </summary>
        public const string OC79AGCID = "OC79AGCID";

        /// <summary>
        /// OC79AGCOID.
        /// </summary>
        public const string OC79AGCOID = "OC79AGCOID";

        /// <summary>
        /// OC79AGOID.
        /// </summary>
        public const string OC79AGOID = "OC79AGOID";

        /// <summary>
        /// OCBEFD.
        /// </summary>
        public const string OCBEFD = "OCBEFD";

        /// <summary>
        /// OCEEFD.
        /// </summary>
        public const string OCEEFD = "OCEEFD";

        /// <summary>
        /// OC79AGCT.
        /// </summary>
        public const string OC79AGCT = "OC79AGCT";

        /// <summary>
        /// OC79ACPRC.
        /// </summary>
        public const string OC79ACPRC = "OC79ACPRC";

        /// <summary>
        /// OCUSER.
        /// </summary>
        public const string OCUSER = "OCUSER";

        /// <summary>
        /// OCJOBN.
        /// </summary>
        public const string OCJOBN = "OCJOBN";

        /// <summary>
        /// OCPID.
        /// </summary>
        public const string OCPID = "OCPID";

        /// <summary>
        /// OCUPMJ.
        /// </summary>
        public const string OCUPMJ = "OCUPMJ";

        /// <summary>
        /// OCTDAY.
        /// </summary>
        public const string OCTDAY = "OCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A73";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OC79AGCID", "OC79AGCID", JdeDataType.Numeric, null, true, true),
        new JdeField("OC79AGCOID", "OC79AGCOID", JdeDataType.Numeric),
        new JdeField("OC79AGOID", "OC79AGOID", JdeDataType.Numeric),
        new JdeField("OCBEFD", "OCBEFD", JdeDataType.Numeric),
        new JdeField("OCEEFD", "OCEEFD", JdeDataType.Numeric),
        new JdeField("OC79AGCT", "OC79AGCT", JdeDataType.String, 20),
        new JdeField("OC79ACPRC", "OC79ACPRC", JdeDataType.Numeric),
        new JdeField("OCUSER", "OCUSER", JdeDataType.String, 20),
        new JdeField("OCJOBN", "OCJOBN", JdeDataType.String, 20),
        new JdeField("OCPID", "OCPID", JdeDataType.String, 20),
        new JdeField("OCUPMJ", "OCUPMJ", JdeDataType.Numeric),
        new JdeField("OCTDAY", "OCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A73_0", "Primary Key on OC79AGCID", new[] { "OC79AGCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A73_2", "Index on OC79AGOID, OC79AGCT, OCBEFD", new[] { "OC79AGOID", "OC79AGCT", "OCBEFD" }),
        new JdeIndex("F79A73_3", "Unique Index on OC79AGCOID, OC79AGOID, OC79AGCT, OCBEFD", new[] { "OC79AGCOID", "OC79AGOID", "OC79AGCT", "OCBEFD" }, isUnique: true)
    };
}
