using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C31T2 - .
/// </summary>
public class F76C31T2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AWDOC.
        /// </summary>
        public const string AWDOC = "AWDOC";

        /// <summary>
        /// AWDCT.
        /// </summary>
        public const string AWDCT = "AWDCT";

        /// <summary>
        /// AWKCO.
        /// </summary>
        public const string AWKCO = "AWKCO";

        /// <summary>
        /// AWSFX.
        /// </summary>
        public const string AWSFX = "AWSFX";

        /// <summary>
        /// AWC76AWCF.
        /// </summary>
        public const string AWC76AWCF = "AWC76AWCF";

        /// <summary>
        /// AWUSER.
        /// </summary>
        public const string AWUSER = "AWUSER";

        /// <summary>
        /// AWPID.
        /// </summary>
        public const string AWPID = "AWPID";

        /// <summary>
        /// AWUPMJ.
        /// </summary>
        public const string AWUPMJ = "AWUPMJ";

        /// <summary>
        /// AWUPMT.
        /// </summary>
        public const string AWUPMT = "AWUPMT";

        /// <summary>
        /// AWJOBN.
        /// </summary>
        public const string AWJOBN = "AWJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76C31T2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AWDOC", "AWDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AWDCT", "AWDCT", JdeDataType.String, 4, true, true),
        new JdeField("AWKCO", "AWKCO", JdeDataType.String, 10, true, true),
        new JdeField("AWSFX", "AWSFX", JdeDataType.String, 6, true, true),
        new JdeField("AWC76AWCF", "AWC76AWCF", JdeDataType.String, 2),
        new JdeField("AWUSER", "AWUSER", JdeDataType.String, 20),
        new JdeField("AWPID", "AWPID", JdeDataType.String, 20),
        new JdeField("AWUPMJ", "AWUPMJ", JdeDataType.Numeric),
        new JdeField("AWUPMT", "AWUPMT", JdeDataType.Numeric),
        new JdeField("AWJOBN", "AWJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C31T2_0", "Primary Key on AWDOC, AWDCT, AWKCO, AWSFX", new[] { "AWDOC", "AWDCT", "AWKCO", "AWSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
