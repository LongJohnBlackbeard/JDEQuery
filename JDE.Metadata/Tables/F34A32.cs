using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A32 - .
/// </summary>
public class F34A32 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GPITM.
        /// </summary>
        public const string GPITM = "GPITM";

        /// <summary>
        /// GPMMCU.
        /// </summary>
        public const string GPMMCU = "GPMMCU";

        /// <summary>
        /// GPCFGSID.
        /// </summary>
        public const string GPCFGSID = "GPCFGSID";

        /// <summary>
        /// GPNNGOP.
        /// </summary>
        public const string GPNNGOP = "GPNNGOP";

        /// <summary>
        /// GPUSER.
        /// </summary>
        public const string GPUSER = "GPUSER";

        /// <summary>
        /// GPPID.
        /// </summary>
        public const string GPPID = "GPPID";

        /// <summary>
        /// GPJOBN.
        /// </summary>
        public const string GPJOBN = "GPJOBN";

        /// <summary>
        /// GPUPMJ.
        /// </summary>
        public const string GPUPMJ = "GPUPMJ";

        /// <summary>
        /// GPUPMT.
        /// </summary>
        public const string GPUPMT = "GPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F34A32";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GPITM", "GPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("GPMMCU", "GPMMCU", JdeDataType.String, 24, true, true),
        new JdeField("GPCFGSID", "GPCFGSID", JdeDataType.String, 64, true, true),
        new JdeField("GPNNGOP", "GPNNGOP", JdeDataType.Numeric),
        new JdeField("GPUSER", "GPUSER", JdeDataType.String, 20),
        new JdeField("GPPID", "GPPID", JdeDataType.String, 20),
        new JdeField("GPJOBN", "GPJOBN", JdeDataType.String, 20),
        new JdeField("GPUPMJ", "GPUPMJ", JdeDataType.Numeric),
        new JdeField("GPUPMT", "GPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A32_0", "Primary Key on GPITM, GPMMCU, GPCFGSID", new[] { "GPITM", "GPMMCU", "GPCFGSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34A32_2", "Index on GPITM, GPCFGSID", new[] { "GPITM", "GPCFGSID" })
    };
}
