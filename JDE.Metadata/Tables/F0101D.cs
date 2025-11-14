using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0101D - .
/// </summary>
public class F0101D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADAN8.
        /// </summary>
        public const string ADAN8 = "ADAN8";

        /// <summary>
        /// ADLNGP.
        /// </summary>
        public const string ADLNGP = "ADLNGP";

        /// <summary>
        /// ADALPH.
        /// </summary>
        public const string ADALPH = "ADALPH";

        /// <summary>
        /// ADALP1.
        /// </summary>
        public const string ADALP1 = "ADALP1";

        /// <summary>
        /// ADEFTB.
        /// </summary>
        public const string ADEFTB = "ADEFTB";

        /// <summary>
        /// ADDC.
        /// </summary>
        public const string ADDC = "ADDC";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADUPMT.
        /// </summary>
        public const string ADUPMT = "ADUPMT";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADFUMATH2.
        /// </summary>
        public const string ADFUMATH2 = "ADFUMATH2";

        /// <summary>
        /// ADFUDATE2.
        /// </summary>
        public const string ADFUDATE2 = "ADFUDATE2";

        /// <summary>
        /// ADFUTUSTR2.
        /// </summary>
        public const string ADFUTUSTR2 = "ADFUTUSTR2";

        /// <summary>
        /// ADFTCHAR2.
        /// </summary>
        public const string ADFTCHAR2 = "ADFTCHAR2";
    }

    /// <inheritdoc />
    public override string TableName => "F0101D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADAN8", "ADAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ADLNGP", "ADLNGP", JdeDataType.String, 4, true, true),
        new JdeField("ADALPH", "ADALPH", JdeDataType.String, 80),
        new JdeField("ADALP1", "ADALP1", JdeDataType.String, 80),
        new JdeField("ADEFTB", "ADEFTB", JdeDataType.Numeric),
        new JdeField("ADDC", "ADDC", JdeDataType.String, 80),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADUPMT", "ADUPMT", JdeDataType.Numeric),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADFUMATH2", "ADFUMATH2", JdeDataType.Numeric),
        new JdeField("ADFUDATE2", "ADFUDATE2", JdeDataType.Numeric),
        new JdeField("ADFUTUSTR2", "ADFUTUSTR2", JdeDataType.String, 80),
        new JdeField("ADFTCHAR2", "ADFTCHAR2", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0101D_0", "Primary Key on ADAN8, ADLNGP", new[] { "ADAN8", "ADLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
