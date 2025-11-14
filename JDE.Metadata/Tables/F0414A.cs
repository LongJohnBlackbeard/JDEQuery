using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0414A - .
/// </summary>
public class F0414A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RNPYID.
        /// </summary>
        public const string RNPYID = "RNPYID";

        /// <summary>
        /// RNRC5.
        /// </summary>
        public const string RNRC5 = "RNRC5";

        /// <summary>
        /// RNDCTM.
        /// </summary>
        public const string RNDCTM = "RNDCTM";

        /// <summary>
        /// RNKCO.
        /// </summary>
        public const string RNKCO = "RNKCO";

        /// <summary>
        /// RNDCT.
        /// </summary>
        public const string RNDCT = "RNDCT";

        /// <summary>
        /// RNDOC.
        /// </summary>
        public const string RNDOC = "RNDOC";

        /// <summary>
        /// RNSFX.
        /// </summary>
        public const string RNSFX = "RNSFX";

        /// <summary>
        /// RNSFXE.
        /// </summary>
        public const string RNSFXE = "RNSFXE";

        /// <summary>
        /// RNPAAP.
        /// </summary>
        public const string RNPAAP = "RNPAAP";

        /// <summary>
        /// RNADSC.
        /// </summary>
        public const string RNADSC = "RNADSC";

        /// <summary>
        /// RNADSA.
        /// </summary>
        public const string RNADSA = "RNADSA";

        /// <summary>
        /// RNPFAP.
        /// </summary>
        public const string RNPFAP = "RNPFAP";

        /// <summary>
        /// RNCDS.
        /// </summary>
        public const string RNCDS = "RNCDS";

        /// <summary>
        /// RNCDSA.
        /// </summary>
        public const string RNCDSA = "RNCDSA";

        /// <summary>
        /// RNCRRM.
        /// </summary>
        public const string RNCRRM = "RNCRRM";

        /// <summary>
        /// RNCRCD.
        /// </summary>
        public const string RNCRCD = "RNCRCD";

        /// <summary>
        /// RNCRR.
        /// </summary>
        public const string RNCRR = "RNCRR";

        /// <summary>
        /// RNGLC.
        /// </summary>
        public const string RNGLC = "RNGLC";

        /// <summary>
        /// RNPOST.
        /// </summary>
        public const string RNPOST = "RNPOST";

        /// <summary>
        /// RNALT6.
        /// </summary>
        public const string RNALT6 = "RNALT6";

        /// <summary>
        /// RNPN.
        /// </summary>
        public const string RNPN = "RNPN";

        /// <summary>
        /// RNFY.
        /// </summary>
        public const string RNFY = "RNFY";

        /// <summary>
        /// RNCTRY.
        /// </summary>
        public const string RNCTRY = "RNCTRY";

        /// <summary>
        /// RNFNLP.
        /// </summary>
        public const string RNFNLP = "RNFNLP";

        /// <summary>
        /// RNAN8.
        /// </summary>
        public const string RNAN8 = "RNAN8";

        /// <summary>
        /// RNCO.
        /// </summary>
        public const string RNCO = "RNCO";

        /// <summary>
        /// RNMCU.
        /// </summary>
        public const string RNMCU = "RNMCU";

        /// <summary>
        /// RNPO.
        /// </summary>
        public const string RNPO = "RNPO";

        /// <summary>
        /// RNRMK.
        /// </summary>
        public const string RNRMK = "RNRMK";

        /// <summary>
        /// RNHCRR.
        /// </summary>
        public const string RNHCRR = "RNHCRR";

        /// <summary>
        /// RNUSER.
        /// </summary>
        public const string RNUSER = "RNUSER";

        /// <summary>
        /// RNPID.
        /// </summary>
        public const string RNPID = "RNPID";

        /// <summary>
        /// RNUPMJ.
        /// </summary>
        public const string RNUPMJ = "RNUPMJ";

        /// <summary>
        /// RNUPMT.
        /// </summary>
        public const string RNUPMT = "RNUPMT";

        /// <summary>
        /// RNJOBN.
        /// </summary>
        public const string RNJOBN = "RNJOBN";

        /// <summary>
        /// RNMIP.
        /// </summary>
        public const string RNMIP = "RNMIP";

        /// <summary>
        /// RNLRFL.
        /// </summary>
        public const string RNLRFL = "RNLRFL";

        /// <summary>
        /// RNBCRC.
        /// </summary>
        public const string RNBCRC = "RNBCRC";

        /// <summary>
        /// RNGFL7.
        /// </summary>
        public const string RNGFL7 = "RNGFL7";

        /// <summary>
        /// RNGFL8.
        /// </summary>
        public const string RNGFL8 = "RNGFL8";

        /// <summary>
        /// RNGAM3.
        /// </summary>
        public const string RNGAM3 = "RNGAM3";

        /// <summary>
        /// RNGAM4.
        /// </summary>
        public const string RNGAM4 = "RNGAM4";

        /// <summary>
        /// RNGEN6.
        /// </summary>
        public const string RNGEN6 = "RNGEN6";

        /// <summary>
        /// RNGEN7.
        /// </summary>
        public const string RNGEN7 = "RNGEN7";

        /// <summary>
        /// RNDRCO.
        /// </summary>
        public const string RNDRCO = "RNDRCO";

        /// <summary>
        /// RNNETTCID.
        /// </summary>
        public const string RNNETTCID = "RNNETTCID";

        /// <summary>
        /// RNNETDOC.
        /// </summary>
        public const string RNNETDOC = "RNNETDOC";

        /// <summary>
        /// RNNETRC5.
        /// </summary>
        public const string RNNETRC5 = "RNNETRC5";

        /// <summary>
        /// RNCNTRTID.
        /// </summary>
        public const string RNCNTRTID = "RNCNTRTID";

        /// <summary>
        /// RNCNTRTCD.
        /// </summary>
        public const string RNCNTRTCD = "RNCNTRTCD";

        /// <summary>
        /// RNWVID.
        /// </summary>
        public const string RNWVID = "RNWVID";

        /// <summary>
        /// RNBLSCD2.
        /// </summary>
        public const string RNBLSCD2 = "RNBLSCD2";

        /// <summary>
        /// RNHARPER.
        /// </summary>
        public const string RNHARPER = "RNHARPER";

        /// <summary>
        /// RNHARSFX.
        /// </summary>
        public const string RNHARSFX = "RNHARSFX";
    }

    /// <inheritdoc />
    public override string TableName => "F0414A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RNPYID", "RNPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RNRC5", "RNRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("RNDCTM", "RNDCTM", JdeDataType.String, 4),
        new JdeField("RNKCO", "RNKCO", JdeDataType.String, 10),
        new JdeField("RNDCT", "RNDCT", JdeDataType.String, 4),
        new JdeField("RNDOC", "RNDOC", JdeDataType.Numeric),
        new JdeField("RNSFX", "RNSFX", JdeDataType.String, 6),
        new JdeField("RNSFXE", "RNSFXE", JdeDataType.Numeric),
        new JdeField("RNPAAP", "RNPAAP", JdeDataType.Numeric),
        new JdeField("RNADSC", "RNADSC", JdeDataType.Numeric),
        new JdeField("RNADSA", "RNADSA", JdeDataType.Numeric),
        new JdeField("RNPFAP", "RNPFAP", JdeDataType.Numeric),
        new JdeField("RNCDS", "RNCDS", JdeDataType.Numeric),
        new JdeField("RNCDSA", "RNCDSA", JdeDataType.Numeric),
        new JdeField("RNCRRM", "RNCRRM", JdeDataType.String, 2),
        new JdeField("RNCRCD", "RNCRCD", JdeDataType.String, 6),
        new JdeField("RNCRR", "RNCRR", JdeDataType.Numeric),
        new JdeField("RNGLC", "RNGLC", JdeDataType.String, 8),
        new JdeField("RNPOST", "RNPOST", JdeDataType.String, 2),
        new JdeField("RNALT6", "RNALT6", JdeDataType.String, 2),
        new JdeField("RNPN", "RNPN", JdeDataType.Numeric),
        new JdeField("RNFY", "RNFY", JdeDataType.Numeric),
        new JdeField("RNCTRY", "RNCTRY", JdeDataType.Numeric),
        new JdeField("RNFNLP", "RNFNLP", JdeDataType.String, 2),
        new JdeField("RNAN8", "RNAN8", JdeDataType.Numeric),
        new JdeField("RNCO", "RNCO", JdeDataType.String, 10),
        new JdeField("RNMCU", "RNMCU", JdeDataType.String, 24),
        new JdeField("RNPO", "RNPO", JdeDataType.String, 16),
        new JdeField("RNRMK", "RNRMK", JdeDataType.String, 60),
        new JdeField("RNHCRR", "RNHCRR", JdeDataType.Numeric),
        new JdeField("RNUSER", "RNUSER", JdeDataType.String, 20),
        new JdeField("RNPID", "RNPID", JdeDataType.String, 20),
        new JdeField("RNUPMJ", "RNUPMJ", JdeDataType.Numeric),
        new JdeField("RNUPMT", "RNUPMT", JdeDataType.Numeric),
        new JdeField("RNJOBN", "RNJOBN", JdeDataType.String, 20),
        new JdeField("RNMIP", "RNMIP", JdeDataType.String, 2),
        new JdeField("RNLRFL", "RNLRFL", JdeDataType.String, 2),
        new JdeField("RNBCRC", "RNBCRC", JdeDataType.String, 6),
        new JdeField("RNGFL7", "RNGFL7", JdeDataType.String, 2),
        new JdeField("RNGFL8", "RNGFL8", JdeDataType.String, 2),
        new JdeField("RNGAM3", "RNGAM3", JdeDataType.Numeric),
        new JdeField("RNGAM4", "RNGAM4", JdeDataType.Numeric),
        new JdeField("RNGEN6", "RNGEN6", JdeDataType.String, 50),
        new JdeField("RNGEN7", "RNGEN7", JdeDataType.String, 50),
        new JdeField("RNDRCO", "RNDRCO", JdeDataType.String, 6),
        new JdeField("RNNETTCID", "RNNETTCID", JdeDataType.Numeric),
        new JdeField("RNNETDOC", "RNNETDOC", JdeDataType.Numeric),
        new JdeField("RNNETRC5", "RNNETRC5", JdeDataType.Numeric),
        new JdeField("RNCNTRTID", "RNCNTRTID", JdeDataType.Numeric),
        new JdeField("RNCNTRTCD", "RNCNTRTCD", JdeDataType.String, 24),
        new JdeField("RNWVID", "RNWVID", JdeDataType.Numeric),
        new JdeField("RNBLSCD2", "RNBLSCD2", JdeDataType.String, 20),
        new JdeField("RNHARPER", "RNHARPER", JdeDataType.String, 12),
        new JdeField("RNHARSFX", "RNHARSFX", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0414A_0", "Primary Key on RNPYID, RNRC5", new[] { "RNPYID", "RNRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0414A_2", "Index on RNAN8, RNDCT, RNDOC, RNKCO, RNSFX, RNSFXE", new[] { "RNAN8", "RNDCT", "RNDOC", "RNKCO", "RNSFX", "RNSFXE" })
    };
}
