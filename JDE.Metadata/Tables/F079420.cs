using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F079420 - .
/// </summary>
public class F079420 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDPWPDBA.
        /// </summary>
        public const string PDPWPDBA = "PDPWPDBA";

        /// <summary>
        /// PDPWAF.
        /// </summary>
        public const string PDPWAF = "PDPWAF";

        /// <summary>
        /// PDPWLSPDBA.
        /// </summary>
        public const string PDPWLSPDBA = "PDPWLSPDBA";

        /// <summary>
        /// PDPWCM.
        /// </summary>
        public const string PDPWCM = "PDPWCM";

        /// <summary>
        /// PDPWMF.
        /// </summary>
        public const string PDPWMF = "PDPWMF";

        /// <summary>
        /// PDPWFMN01.
        /// </summary>
        public const string PDPWFMN01 = "PDPWFMN01";

        /// <summary>
        /// PDPWFMN02.
        /// </summary>
        public const string PDPWFMN02 = "PDPWFMN02";

        /// <summary>
        /// PDPWFMN03.
        /// </summary>
        public const string PDPWFMN03 = "PDPWFMN03";

        /// <summary>
        /// PDPWFST01.
        /// </summary>
        public const string PDPWFST01 = "PDPWFST01";

        /// <summary>
        /// PDPWFST02.
        /// </summary>
        public const string PDPWFST02 = "PDPWFST02";

        /// <summary>
        /// PDPWFST03.
        /// </summary>
        public const string PDPWFST03 = "PDPWFST03";

        /// <summary>
        /// PDPWFCH01.
        /// </summary>
        public const string PDPWFCH01 = "PDPWFCH01";

        /// <summary>
        /// PDPWFCH02.
        /// </summary>
        public const string PDPWFCH02 = "PDPWFCH02";

        /// <summary>
        /// PDPWFCH03.
        /// </summary>
        public const string PDPWFCH03 = "PDPWFCH03";

        /// <summary>
        /// PDPWFJD01.
        /// </summary>
        public const string PDPWFJD01 = "PDPWFJD01";

        /// <summary>
        /// PDPWFJD02.
        /// </summary>
        public const string PDPWFJD02 = "PDPWFJD02";

        /// <summary>
        /// PDPWFJD03.
        /// </summary>
        public const string PDPWFJD03 = "PDPWFJD03";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDUPMT.
        /// </summary>
        public const string PDUPMT = "PDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F079420";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDPWPDBA", "PDPWPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("PDPWAF", "PDPWAF", JdeDataType.String, 2),
        new JdeField("PDPWLSPDBA", "PDPWLSPDBA", JdeDataType.Numeric),
        new JdeField("PDPWCM", "PDPWCM", JdeDataType.String, 4),
        new JdeField("PDPWMF", "PDPWMF", JdeDataType.String, 2),
        new JdeField("PDPWFMN01", "PDPWFMN01", JdeDataType.Numeric),
        new JdeField("PDPWFMN02", "PDPWFMN02", JdeDataType.Numeric),
        new JdeField("PDPWFMN03", "PDPWFMN03", JdeDataType.Numeric),
        new JdeField("PDPWFST01", "PDPWFST01", JdeDataType.String, 40),
        new JdeField("PDPWFST02", "PDPWFST02", JdeDataType.String, 40),
        new JdeField("PDPWFST03", "PDPWFST03", JdeDataType.String, 80),
        new JdeField("PDPWFCH01", "PDPWFCH01", JdeDataType.String, 2),
        new JdeField("PDPWFCH02", "PDPWFCH02", JdeDataType.String, 2),
        new JdeField("PDPWFCH03", "PDPWFCH03", JdeDataType.String, 2),
        new JdeField("PDPWFJD01", "PDPWFJD01", JdeDataType.Numeric),
        new JdeField("PDPWFJD02", "PDPWFJD02", JdeDataType.Numeric),
        new JdeField("PDPWFJD03", "PDPWFJD03", JdeDataType.Numeric),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F079420_0", "Primary Key on PDPWPDBA", new[] { "PDPWPDBA" }, isUnique: true, isPrimaryKey: true)
    };
}
