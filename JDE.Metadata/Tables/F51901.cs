using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51901 - .
/// </summary>
public class F51901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GPAID.
        /// </summary>
        public const string GPAID = "GPAID";

        /// <summary>
        /// GPPNST.
        /// </summary>
        public const string GPPNST = "GPPNST";

        /// <summary>
        /// GPPNFN.
        /// </summary>
        public const string GPPNFN = "GPPNFN";

        /// <summary>
        /// GPATST.
        /// </summary>
        public const string GPATST = "GPATST";

        /// <summary>
        /// GPATFN.
        /// </summary>
        public const string GPATFN = "GPATFN";

        /// <summary>
        /// GPSCHN.
        /// </summary>
        public const string GPSCHN = "GPSCHN";

        /// <summary>
        /// GPP3ID.
        /// </summary>
        public const string GPP3ID = "GPP3ID";

        /// <summary>
        /// GPACID.
        /// </summary>
        public const string GPACID = "GPACID";

        /// <summary>
        /// GPRID.
        /// </summary>
        public const string GPRID = "GPRID";

        /// <summary>
        /// GPRDES.
        /// </summary>
        public const string GPRDES = "GPRDES";

        /// <summary>
        /// GPP3CA.
        /// </summary>
        public const string GPP3CA = "GPP3CA";

        /// <summary>
        /// GPP3AC.
        /// </summary>
        public const string GPP3AC = "GPP3AC";

        /// <summary>
        /// GPPOST.
        /// </summary>
        public const string GPPOST = "GPPOST";

        /// <summary>
        /// GPOSF.
        /// </summary>
        public const string GPOSF = "GPOSF";

        /// <summary>
        /// GPCSHF.
        /// </summary>
        public const string GPCSHF = "GPCSHF";

        /// <summary>
        /// GPPASQ.
        /// </summary>
        public const string GPPASQ = "GPPASQ";

        /// <summary>
        /// GPNDC.
        /// </summary>
        public const string GPNDC = "GPNDC";

        /// <summary>
        /// GPHPF.
        /// </summary>
        public const string GPHPF = "GPHPF";

        /// <summary>
        /// GPASJ.
        /// </summary>
        public const string GPASJ = "GPASJ";

        /// <summary>
        /// GPMCU.
        /// </summary>
        public const string GPMCU = "GPMCU";

        /// <summary>
        /// GPOBJ.
        /// </summary>
        public const string GPOBJ = "GPOBJ";

        /// <summary>
        /// GPSUB.
        /// </summary>
        public const string GPSUB = "GPSUB";

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
    public override string TableName => "F51901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GPAID", "GPAID", JdeDataType.String, 16, true, true),
        new JdeField("GPPNST", "GPPNST", JdeDataType.Numeric),
        new JdeField("GPPNFN", "GPPNFN", JdeDataType.Numeric),
        new JdeField("GPATST", "GPATST", JdeDataType.Numeric),
        new JdeField("GPATFN", "GPATFN", JdeDataType.Numeric),
        new JdeField("GPSCHN", "GPSCHN", JdeDataType.String, 20),
        new JdeField("GPP3ID", "GPP3ID", JdeDataType.String, 8),
        new JdeField("GPACID", "GPACID", JdeDataType.String, 16),
        new JdeField("GPRID", "GPRID", JdeDataType.String, 16),
        new JdeField("GPRDES", "GPRDES", JdeDataType.String, 2),
        new JdeField("GPP3CA", "GPP3CA", JdeDataType.String, 22),
        new JdeField("GPP3AC", "GPP3AC", JdeDataType.String, 2),
        new JdeField("GPPOST", "GPPOST", JdeDataType.String, 2),
        new JdeField("GPOSF", "GPOSF", JdeDataType.Numeric),
        new JdeField("GPCSHF", "GPCSHF", JdeDataType.Numeric),
        new JdeField("GPPASQ", "GPPASQ", JdeDataType.Numeric),
        new JdeField("GPNDC", "GPNDC", JdeDataType.Numeric),
        new JdeField("GPHPF", "GPHPF", JdeDataType.String, 2),
        new JdeField("GPASJ", "GPASJ", JdeDataType.Numeric),
        new JdeField("GPMCU", "GPMCU", JdeDataType.String, 24),
        new JdeField("GPOBJ", "GPOBJ", JdeDataType.String, 12),
        new JdeField("GPSUB", "GPSUB", JdeDataType.String, 16),
        new JdeField("GPUSER", "GPUSER", JdeDataType.String, 20),
        new JdeField("GPPID", "GPPID", JdeDataType.String, 20),
        new JdeField("GPJOBN", "GPJOBN", JdeDataType.String, 20),
        new JdeField("GPUPMJ", "GPUPMJ", JdeDataType.Numeric),
        new JdeField("GPUPMT", "GPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51901_0", "Primary Key on GPAID", new[] { "GPAID" }, isUnique: true, isPrimaryKey: true)
    };
}
