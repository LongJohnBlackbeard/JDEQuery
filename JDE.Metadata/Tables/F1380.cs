using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1380 - .
/// </summary>
public class F1380 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EAEQGP.
        /// </summary>
        public const string EAEQGP = "EAEQGP";

        /// <summary>
        /// EAEQSP.
        /// </summary>
        public const string EAEQSP = "EAEQSP";

        /// <summary>
        /// EAECAT.
        /// </summary>
        public const string EAECAT = "EAECAT";

        /// <summary>
        /// EADL01.
        /// </summary>
        public const string EADL01 = "EADL01";

        /// <summary>
        /// EADTFR.
        /// </summary>
        public const string EADTFR = "EADTFR";

        /// <summary>
        /// EADTTO.
        /// </summary>
        public const string EADTTO = "EADTTO";

        /// <summary>
        /// EAGEDT.
        /// </summary>
        public const string EAGEDT = "EAGEDT";

        /// <summary>
        /// EAEQFL.
        /// </summary>
        public const string EAEQFL = "EAEQFL";

        /// <summary>
        /// EACRTU.
        /// </summary>
        public const string EACRTU = "EACRTU";

        /// <summary>
        /// EAUSER.
        /// </summary>
        public const string EAUSER = "EAUSER";

        /// <summary>
        /// EAPID.
        /// </summary>
        public const string EAPID = "EAPID";

        /// <summary>
        /// EAMKEY.
        /// </summary>
        public const string EAMKEY = "EAMKEY";

        /// <summary>
        /// EAUPMJ.
        /// </summary>
        public const string EAUPMJ = "EAUPMJ";

        /// <summary>
        /// EAUPMT.
        /// </summary>
        public const string EAUPMT = "EAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1380";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EAEQGP", "EAEQGP", JdeDataType.String, 60, true, true),
        new JdeField("EAEQSP", "EAEQSP", JdeDataType.String, 60, true, true),
        new JdeField("EAECAT", "EAECAT", JdeDataType.String, 20),
        new JdeField("EADL01", "EADL01", JdeDataType.String, 60),
        new JdeField("EADTFR", "EADTFR", JdeDataType.Numeric),
        new JdeField("EADTTO", "EADTTO", JdeDataType.Numeric),
        new JdeField("EAGEDT", "EAGEDT", JdeDataType.Numeric),
        new JdeField("EAEQFL", "EAEQFL", JdeDataType.String, 2),
        new JdeField("EACRTU", "EACRTU", JdeDataType.String, 20),
        new JdeField("EAUSER", "EAUSER", JdeDataType.String, 20),
        new JdeField("EAPID", "EAPID", JdeDataType.String, 20),
        new JdeField("EAMKEY", "EAMKEY", JdeDataType.String, 30),
        new JdeField("EAUPMJ", "EAUPMJ", JdeDataType.Numeric),
        new JdeField("EAUPMT", "EAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1380_0", "Primary Key on EAEQGP, EAEQSP", new[] { "EAEQGP", "EAEQSP" }, isUnique: true, isPrimaryKey: true)
    };
}
