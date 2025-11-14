using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF05A - .
/// </summary>
public class F90CF05A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCQSTGRPID.
        /// </summary>
        public const string CCQSTGRPID = "CCQSTGRPID";

        /// <summary>
        /// CCQUSTID.
        /// </summary>
        public const string CCQUSTID = "CCQUSTID";

        /// <summary>
        /// CCQSTGRODR.
        /// </summary>
        public const string CCQSTGRODR = "CCQSTGRODR";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF05A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCQSTGRPID", "CCQSTGRPID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCQUSTID", "CCQUSTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCQSTGRODR", "CCQSTGRODR", JdeDataType.Numeric),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF05A_0", "Primary Key on CCQSTGRPID, CCQUSTID", new[] { "CCQSTGRPID", "CCQUSTID" }, isUnique: true, isPrimaryKey: true)
    };
}
