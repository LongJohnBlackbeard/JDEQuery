using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF06A - .
/// </summary>
public class F90CF06A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCQUSTID.
        /// </summary>
        public const string CCQUSTID = "CCQUSTID";

        /// <summary>
        /// CCLANG.
        /// </summary>
        public const string CCLANG = "CCLANG";

        /// <summary>
        /// CCQUSTGUD.
        /// </summary>
        public const string CCQUSTGUD = "CCQUSTGUD";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCQUSDESC.
        /// </summary>
        public const string CCQUSDESC = "CCQUSDESC";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF06A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCQUSTID", "CCQUSTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCLANG", "CCLANG", JdeDataType.String, 4, true, true),
        new JdeField("CCQUSTGUD", "CCQUSTGUD", JdeDataType.String, 510),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCQUSDESC", "CCQUSDESC", JdeDataType.String, 2000)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF06A_0", "Primary Key on CCQUSTID, CCLANG", new[] { "CCQUSTID", "CCLANG" }, isUnique: true, isPrimaryKey: true)
    };
}
