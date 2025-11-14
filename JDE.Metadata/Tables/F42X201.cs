using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X201 - .
/// </summary>
public class F42X201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PS42XPSIM.
        /// </summary>
        public const string PS42XPSIM = "PS42XPSIM";

        /// <summary>
        /// PS42XSCEN.
        /// </summary>
        public const string PS42XSCEN = "PS42XSCEN";

        /// <summary>
        /// PSSTRDTJ.
        /// </summary>
        public const string PSSTRDTJ = "PSSTRDTJ";

        /// <summary>
        /// PSITM.
        /// </summary>
        public const string PSITM = "PSITM";

        /// <summary>
        /// PSPRGR.
        /// </summary>
        public const string PSPRGR = "PSPRGR";

        /// <summary>
        /// PSAN8.
        /// </summary>
        public const string PSAN8 = "PSAN8";

        /// <summary>
        /// PSCPGP.
        /// </summary>
        public const string PSCPGP = "PSCPGP";

        /// <summary>
        /// PSMCU.
        /// </summary>
        public const string PSMCU = "PSMCU";

        /// <summary>
        /// PSUNCS.
        /// </summary>
        public const string PSUNCS = "PSUNCS";

        /// <summary>
        /// PS42XCOSTF.
        /// </summary>
        public const string PS42XCOSTF = "PS42XCOSTF";

        /// <summary>
        /// PSUPRC.
        /// </summary>
        public const string PSUPRC = "PSUPRC";

        /// <summary>
        /// PS42XPRCF.
        /// </summary>
        public const string PS42XPRCF = "PS42XPRCF";

        /// <summary>
        /// PS42XFORF.
        /// </summary>
        public const string PS42XFORF = "PS42XFORF";

        /// <summary>
        /// PS42XNPER.
        /// </summary>
        public const string PS42XNPER = "PS42XNPER";

        /// <summary>
        /// PS42XADPR.
        /// </summary>
        public const string PS42XADPR = "PS42XADPR";

        /// <summary>
        /// PSUSER.
        /// </summary>
        public const string PSUSER = "PSUSER";

        /// <summary>
        /// PSPID.
        /// </summary>
        public const string PSPID = "PSPID";

        /// <summary>
        /// PSJOBN.
        /// </summary>
        public const string PSJOBN = "PSJOBN";

        /// <summary>
        /// PSUPMJ.
        /// </summary>
        public const string PSUPMJ = "PSUPMJ";

        /// <summary>
        /// PSTDAY.
        /// </summary>
        public const string PSTDAY = "PSTDAY";

        /// <summary>
        /// PS42XREV.
        /// </summary>
        public const string PS42XREV = "PS42XREV";

        /// <summary>
        /// PSKCOO.
        /// </summary>
        public const string PSKCOO = "PSKCOO";
    }

    /// <inheritdoc />
    public override string TableName => "F42X201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PS42XPSIM", "PS42XPSIM", JdeDataType.String, 80, true, true),
        new JdeField("PS42XSCEN", "PS42XSCEN", JdeDataType.Numeric, null, true, true),
        new JdeField("PSSTRDTJ", "PSSTRDTJ", JdeDataType.Numeric),
        new JdeField("PSITM", "PSITM", JdeDataType.Numeric),
        new JdeField("PSPRGR", "PSPRGR", JdeDataType.String, 16),
        new JdeField("PSAN8", "PSAN8", JdeDataType.Numeric),
        new JdeField("PSCPGP", "PSCPGP", JdeDataType.String, 16),
        new JdeField("PSMCU", "PSMCU", JdeDataType.String, 24),
        new JdeField("PSUNCS", "PSUNCS", JdeDataType.Numeric),
        new JdeField("PS42XCOSTF", "PS42XCOSTF", JdeDataType.Numeric),
        new JdeField("PSUPRC", "PSUPRC", JdeDataType.Numeric),
        new JdeField("PS42XPRCF", "PS42XPRCF", JdeDataType.Numeric),
        new JdeField("PS42XFORF", "PS42XFORF", JdeDataType.Numeric),
        new JdeField("PS42XNPER", "PS42XNPER", JdeDataType.Numeric),
        new JdeField("PS42XADPR", "PS42XADPR", JdeDataType.String, 2),
        new JdeField("PSUSER", "PSUSER", JdeDataType.String, 20),
        new JdeField("PSPID", "PSPID", JdeDataType.String, 20),
        new JdeField("PSJOBN", "PSJOBN", JdeDataType.String, 20),
        new JdeField("PSUPMJ", "PSUPMJ", JdeDataType.Numeric),
        new JdeField("PSTDAY", "PSTDAY", JdeDataType.Numeric),
        new JdeField("PS42XREV", "PS42XREV", JdeDataType.Numeric, null, true, true),
        new JdeField("PSKCOO", "PSKCOO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X201_0", "Primary Key on PS42XPSIM, PS42XSCEN, PS42XREV", new[] { "PS42XPSIM", "PS42XSCEN", "PS42XREV" }, isUnique: true, isPrimaryKey: true)
    };
}
