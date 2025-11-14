using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74101T - .
/// </summary>
public class F74101T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFAN8.
        /// </summary>
        public const string TFAN8 = "TFAN8";

        /// <summary>
        /// TFK74TAN8.
        /// </summary>
        public const string TFK74TAN8 = "TFK74TAN8";

        /// <summary>
        /// TFK74ENPID.
        /// </summary>
        public const string TFK74ENPID = "TFK74ENPID";

        /// <summary>
        /// TFK74SCMID.
        /// </summary>
        public const string TFK74SCMID = "TFK74SCMID";

        /// <summary>
        /// TFK74EINVF.
        /// </summary>
        public const string TFK74EINVF = "TFK74EINVF";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFUPMT.
        /// </summary>
        public const string TFUPMT = "TFUPMT";

        /// <summary>
        /// TFYFUTDT.
        /// </summary>
        public const string TFYFUTDT = "TFYFUTDT";

        /// <summary>
        /// TFFUT3.
        /// </summary>
        public const string TFFUT3 = "TFFUT3";

        /// <summary>
        /// TFFUTCH1.
        /// </summary>
        public const string TFFUTCH1 = "TFFUTCH1";

        /// <summary>
        /// TFX2.
        /// </summary>
        public const string TFX2 = "TFX2";

        /// <summary>
        /// TFFFU4.
        /// </summary>
        public const string TFFFU4 = "TFFFU4";
    }

    /// <inheritdoc />
    public override string TableName => "F74101T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFAN8", "TFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TFK74TAN8", "TFK74TAN8", JdeDataType.Numeric),
        new JdeField("TFK74ENPID", "TFK74ENPID", JdeDataType.String, 60),
        new JdeField("TFK74SCMID", "TFK74SCMID", JdeDataType.String, 20),
        new JdeField("TFK74EINVF", "TFK74EINVF", JdeDataType.String, 2),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric),
        new JdeField("TFYFUTDT", "TFYFUTDT", JdeDataType.Numeric),
        new JdeField("TFFUT3", "TFFUT3", JdeDataType.String, 60),
        new JdeField("TFFUTCH1", "TFFUTCH1", JdeDataType.String, 2),
        new JdeField("TFX2", "TFX2", JdeDataType.String, 2),
        new JdeField("TFFFU4", "TFFFU4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74101T_0", "Primary Key on TFAN8", new[] { "TFAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
