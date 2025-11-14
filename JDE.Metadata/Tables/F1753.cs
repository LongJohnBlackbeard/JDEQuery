using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1753 - .
/// </summary>
public class F1753 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GPCALLQ.
        /// </summary>
        public const string GPCALLQ = "GPCALLQ";

        /// <summary>
        /// GPPRIOR.
        /// </summary>
        public const string GPPRIOR = "GPPRIOR";

        /// <summary>
        /// GPESC1.
        /// </summary>
        public const string GPESC1 = "GPESC1";

        /// <summary>
        /// GPDSS7.
        /// </summary>
        public const string GPDSS7 = "GPDSS7";

        /// <summary>
        /// GPEPR3.
        /// </summary>
        public const string GPEPR3 = "GPEPR3";

        /// <summary>
        /// GPEPR1.
        /// </summary>
        public const string GPEPR1 = "GPEPR1";

        /// <summary>
        /// GPEPR4.
        /// </summary>
        public const string GPEPR4 = "GPEPR4";

        /// <summary>
        /// GPEPRIR.
        /// </summary>
        public const string GPEPRIR = "GPEPRIR";

        /// <summary>
        /// GPUSER.
        /// </summary>
        public const string GPUSER = "GPUSER";

        /// <summary>
        /// GPUPMJ.
        /// </summary>
        public const string GPUPMJ = "GPUPMJ";

        /// <summary>
        /// GPUPMT.
        /// </summary>
        public const string GPUPMT = "GPUPMT";

        /// <summary>
        /// GPJOBN.
        /// </summary>
        public const string GPJOBN = "GPJOBN";

        /// <summary>
        /// GPPID.
        /// </summary>
        public const string GPPID = "GPPID";

        /// <summary>
        /// GPESCPER.
        /// </summary>
        public const string GPESCPER = "GPESCPER";

        /// <summary>
        /// GPWARPER.
        /// </summary>
        public const string GPWARPER = "GPWARPER";

        /// <summary>
        /// GPRESPER.
        /// </summary>
        public const string GPRESPER = "GPRESPER";

        /// <summary>
        /// GPSTRPER.
        /// </summary>
        public const string GPSTRPER = "GPSTRPER";
    }

    /// <inheritdoc />
    public override string TableName => "F1753";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GPCALLQ", "GPCALLQ", JdeDataType.Numeric, null, true, true),
        new JdeField("GPPRIOR", "GPPRIOR", JdeDataType.String, 4, true, true),
        new JdeField("GPESC1", "GPESC1", JdeDataType.String, 2, true, true),
        new JdeField("GPDSS7", "GPDSS7", JdeDataType.Numeric),
        new JdeField("GPEPR3", "GPEPR3", JdeDataType.Numeric),
        new JdeField("GPEPR1", "GPEPR1", JdeDataType.Numeric),
        new JdeField("GPEPR4", "GPEPR4", JdeDataType.Numeric),
        new JdeField("GPEPRIR", "GPEPRIR", JdeDataType.String, 4),
        new JdeField("GPUSER", "GPUSER", JdeDataType.String, 20),
        new JdeField("GPUPMJ", "GPUPMJ", JdeDataType.Numeric),
        new JdeField("GPUPMT", "GPUPMT", JdeDataType.Numeric),
        new JdeField("GPJOBN", "GPJOBN", JdeDataType.String, 20),
        new JdeField("GPPID", "GPPID", JdeDataType.String, 20),
        new JdeField("GPESCPER", "GPESCPER", JdeDataType.Numeric),
        new JdeField("GPWARPER", "GPWARPER", JdeDataType.Numeric),
        new JdeField("GPRESPER", "GPRESPER", JdeDataType.Numeric),
        new JdeField("GPSTRPER", "GPSTRPER", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1753_0", "Primary Key on GPCALLQ, GPPRIOR, GPESC1", new[] { "GPCALLQ", "GPPRIOR", "GPESC1" }, isUnique: true, isPrimaryKey: true)
    };
}
