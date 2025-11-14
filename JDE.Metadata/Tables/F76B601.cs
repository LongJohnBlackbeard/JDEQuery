using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B601 - .
/// </summary>
public class F76B601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDCTR.
        /// </summary>
        public const string LDCTR = "LDCTR";

        /// <summary>
        /// LDB76CTEXT.
        /// </summary>
        public const string LDB76CTEXT = "LDB76CTEXT";

        /// <summary>
        /// LDFCHAR1.
        /// </summary>
        public const string LDFCHAR1 = "LDFCHAR1";

        /// <summary>
        /// LDFCHAR2.
        /// </summary>
        public const string LDFCHAR2 = "LDFCHAR2";

        /// <summary>
        /// LDFCHAR3.
        /// </summary>
        public const string LDFCHAR3 = "LDFCHAR3";

        /// <summary>
        /// LDFUDTE1.
        /// </summary>
        public const string LDFUDTE1 = "LDFUDTE1";

        /// <summary>
        /// LDFUDTE2.
        /// </summary>
        public const string LDFUDTE2 = "LDFUDTE2";

        /// <summary>
        /// LDFUDTE3.
        /// </summary>
        public const string LDFUDTE3 = "LDFUDTE3";

        /// <summary>
        /// LDFSTRN1.
        /// </summary>
        public const string LDFSTRN1 = "LDFSTRN1";

        /// <summary>
        /// LDFSTRN2.
        /// </summary>
        public const string LDFSTRN2 = "LDFSTRN2";

        /// <summary>
        /// LDFSTRN3.
        /// </summary>
        public const string LDFSTRN3 = "LDFSTRN3";

        /// <summary>
        /// LDFNUMB1.
        /// </summary>
        public const string LDFNUMB1 = "LDFNUMB1";

        /// <summary>
        /// LDFNUMB2.
        /// </summary>
        public const string LDFNUMB2 = "LDFNUMB2";

        /// <summary>
        /// LDFNUMB3.
        /// </summary>
        public const string LDFNUMB3 = "LDFNUMB3";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDCTR", "LDCTR", JdeDataType.String, 6, true, true),
        new JdeField("LDB76CTEXT", "LDB76CTEXT", JdeDataType.String, 2000),
        new JdeField("LDFCHAR1", "LDFCHAR1", JdeDataType.String, 2),
        new JdeField("LDFCHAR2", "LDFCHAR2", JdeDataType.String, 2),
        new JdeField("LDFCHAR3", "LDFCHAR3", JdeDataType.String, 2),
        new JdeField("LDFUDTE1", "LDFUDTE1", JdeDataType.Numeric),
        new JdeField("LDFUDTE2", "LDFUDTE2", JdeDataType.Numeric),
        new JdeField("LDFUDTE3", "LDFUDTE3", JdeDataType.Numeric),
        new JdeField("LDFSTRN1", "LDFSTRN1", JdeDataType.String, 100),
        new JdeField("LDFSTRN2", "LDFSTRN2", JdeDataType.String, 100),
        new JdeField("LDFSTRN3", "LDFSTRN3", JdeDataType.String, 100),
        new JdeField("LDFNUMB1", "LDFNUMB1", JdeDataType.Numeric),
        new JdeField("LDFNUMB2", "LDFNUMB2", JdeDataType.Numeric),
        new JdeField("LDFNUMB3", "LDFNUMB3", JdeDataType.Numeric),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B601_0", "Primary Key on LDCTR", new[] { "LDCTR" }, isUnique: true, isPrimaryKey: true)
    };
}
