using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF050 - .
/// </summary>
public class F90CF050 : JdeTable
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
        /// CCQSTGRPNM.
        /// </summary>
        public const string CCQSTGRPNM = "CCQSTGRPNM";

        /// <summary>
        /// CCQSTGRSTS.
        /// </summary>
        public const string CCQSTGRSTS = "CCQSTGRSTS";

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

        /// <summary>
        /// CCQGRPDESC.
        /// </summary>
        public const string CCQGRPDESC = "CCQGRPDESC";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCQSTGRPID", "CCQSTGRPID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCQSTGRPNM", "CCQSTGRPNM", JdeDataType.String, 80),
        new JdeField("CCQSTGRSTS", "CCQSTGRSTS", JdeDataType.String, 2),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCQGRPDESC", "CCQGRPDESC", JdeDataType.String, 508)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF050_0", "Primary Key on CCQSTGRPID", new[] { "CCQSTGRPID" }, isUnique: true, isPrimaryKey: true)
    };
}
