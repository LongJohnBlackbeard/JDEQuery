using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R201 - .
/// </summary>
public class F74R201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VMDCTO.
        /// </summary>
        public const string VMDCTO = "VMDCTO";

        /// <summary>
        /// VMLNTY.
        /// </summary>
        public const string VMLNTY = "VMLNTY";

        /// <summary>
        /// VMR74VATM.
        /// </summary>
        public const string VMR74VATM = "VMR74VATM";

        /// <summary>
        /// VMUSER.
        /// </summary>
        public const string VMUSER = "VMUSER";

        /// <summary>
        /// VMPID.
        /// </summary>
        public const string VMPID = "VMPID";

        /// <summary>
        /// VMJOBN.
        /// </summary>
        public const string VMJOBN = "VMJOBN";

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
    public override string TableName => "F74R201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VMDCTO", "VMDCTO", JdeDataType.String, 4, true, true),
        new JdeField("VMLNTY", "VMLNTY", JdeDataType.String, 4, true, true),
        new JdeField("VMR74VATM", "VMR74VATM", JdeDataType.String, 2),
        new JdeField("VMUSER", "VMUSER", JdeDataType.String, 20),
        new JdeField("VMPID", "VMPID", JdeDataType.String, 20),
        new JdeField("VMJOBN", "VMJOBN", JdeDataType.String, 20),
        new JdeField("VMUPMJ", "VMUPMJ", JdeDataType.Numeric),
        new JdeField("VMUPMT", "VMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R201_0", "Primary Key on VMDCTO, VMLNTY", new[] { "VMDCTO", "VMLNTY" }, isUnique: true, isPrimaryKey: true)
    };
}
