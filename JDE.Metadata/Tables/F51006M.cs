using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51006M - .
/// </summary>
public class F51006M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VMCRCD.
        /// </summary>
        public const string VMCRCD = "VMCRCD";

        /// <summary>
        /// VMEXSYSINS.
        /// </summary>
        public const string VMEXSYSINS = "VMEXSYSINS";

        /// <summary>
        /// VMCRDC.
        /// </summary>
        public const string VMCRDC = "VMCRDC";

        /// <summary>
        /// VMUSER.
        /// </summary>
        public const string VMUSER = "VMUSER";

        /// <summary>
        /// VMPID.
        /// </summary>
        public const string VMPID = "VMPID";

        /// <summary>
        /// VMMKEY.
        /// </summary>
        public const string VMMKEY = "VMMKEY";

        /// <summary>
        /// VMUPMJ.
        /// </summary>
        public const string VMUPMJ = "VMUPMJ";

        /// <summary>
        /// VMUPMT.
        /// </summary>
        public const string VMUPMT = "VMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F51006M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VMCRCD", "VMCRCD", JdeDataType.String, 6, true, true),
        new JdeField("VMEXSYSINS", "VMEXSYSINS", JdeDataType.String, 400, true, true),
        new JdeField("VMCRDC", "VMCRDC", JdeDataType.String, 6),
        new JdeField("VMUSER", "VMUSER", JdeDataType.String, 20),
        new JdeField("VMPID", "VMPID", JdeDataType.String, 20),
        new JdeField("VMMKEY", "VMMKEY", JdeDataType.String, 30),
        new JdeField("VMUPMJ", "VMUPMJ", JdeDataType.Numeric),
        new JdeField("VMUPMT", "VMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51006M_0", "Primary Key on VMCRCD, VMEXSYSINS", new[] { "VMCRCD", "VMEXSYSINS" }, isUnique: true, isPrimaryKey: true)
    };
}
