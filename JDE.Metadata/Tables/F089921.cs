using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F089921 - .
/// </summary>
public class F089921 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTUKID.
        /// </summary>
        public const string DTUKID = "DTUKID";

        /// <summary>
        /// DTLIN.
        /// </summary>
        public const string DTLIN = "DTLIN";

        /// <summary>
        /// DTOWBSDF.
        /// </summary>
        public const string DTOWBSDF = "DTOWBSDF";

        /// <summary>
        /// DTBLO.
        /// </summary>
        public const string DTBLO = "DTBLO";

        /// <summary>
        /// DTBSDO.
        /// </summary>
        public const string DTBSDO = "DTBSDO";

        /// <summary>
        /// DTAOR1.
        /// </summary>
        public const string DTAOR1 = "DTAOR1";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTJOBN.
        /// </summary>
        public const string DTJOBN = "DTJOBN";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";

        /// <summary>
        /// DTUPMT.
        /// </summary>
        public const string DTUPMT = "DTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F089921";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTUKID", "DTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DTLIN", "DTLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("DTOWBSDF", "DTOWBSDF", JdeDataType.String, 20),
        new JdeField("DTBLO", "DTBLO", JdeDataType.String, 4),
        new JdeField("DTBSDO", "DTBSDO", JdeDataType.String, 200),
        new JdeField("DTAOR1", "DTAOR1", JdeDataType.String, 6),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTJOBN", "DTJOBN", JdeDataType.String, 20),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric),
        new JdeField("DTUPMT", "DTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F089921_0", "Primary Key on DTUKID, DTLIN", new[] { "DTUKID", "DTLIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F089921_2", "Index on SYS_NC00012$, DTLIN", new[] { "SYS_NC00012$", "DTLIN" })
    };
}
