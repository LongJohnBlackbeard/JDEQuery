using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R30WF - .
/// </summary>
public class F40R30WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSCTID.
        /// </summary>
        public const string DSCTID = "DSCTID";

        /// <summary>
        /// DSJOBS.
        /// </summary>
        public const string DSJOBS = "DSJOBS";

        /// <summary>
        /// DSDEID.
        /// </summary>
        public const string DSDEID = "DSDEID";

        /// <summary>
        /// DSCRTSOCL.
        /// </summary>
        public const string DSCRTSOCL = "DSCRTSOCL";

        /// <summary>
        /// DSSOACTION.
        /// </summary>
        public const string DSSOACTION = "DSSOACTION";

        /// <summary>
        /// DSHOLDORD.
        /// </summary>
        public const string DSHOLDORD = "DSHOLDORD";

        /// <summary>
        /// DSSOLSTS.
        /// </summary>
        public const string DSSOLSTS = "DSSOLSTS";

        /// <summary>
        /// DSRRCD.
        /// </summary>
        public const string DSRRCD = "DSRRCD";

        /// <summary>
        /// DSSOSTSNTF.
        /// </summary>
        public const string DSSOSTSNTF = "DSSOSTSNTF";

        /// <summary>
        /// DSDOCO.
        /// </summary>
        public const string DSDOCO = "DSDOCO";

        /// <summary>
        /// DSDCTO.
        /// </summary>
        public const string DSDCTO = "DSDCTO";

        /// <summary>
        /// DSKCOO.
        /// </summary>
        public const string DSKCOO = "DSKCOO";

        /// <summary>
        /// DSLNID.
        /// </summary>
        public const string DSLNID = "DSLNID";

        /// <summary>
        /// DSMCU.
        /// </summary>
        public const string DSMCU = "DSMCU";

        /// <summary>
        /// DSAN8.
        /// </summary>
        public const string DSAN8 = "DSAN8";

        /// <summary>
        /// DSSHAN.
        /// </summary>
        public const string DSSHAN = "DSSHAN";

        /// <summary>
        /// DSITM.
        /// </summary>
        public const string DSITM = "DSITM";

        /// <summary>
        /// DSRQSHPQTY.
        /// </summary>
        public const string DSRQSHPQTY = "DSRQSHPQTY";

        /// <summary>
        /// DSUOM.
        /// </summary>
        public const string DSUOM = "DSUOM";

        /// <summary>
        /// DSRSDJ.
        /// </summary>
        public const string DSRSDJ = "DSRSDJ";

        /// <summary>
        /// DSRSDT.
        /// </summary>
        public const string DSRSDT = "DSRSDT";

        /// <summary>
        /// DSSOBCKORD.
        /// </summary>
        public const string DSSOBCKORD = "DSSOBCKORD";

        /// <summary>
        /// DSBQNC.
        /// </summary>
        public const string DSBQNC = "DSBQNC";

        /// <summary>
        /// DSINVADV.
        /// </summary>
        public const string DSINVADV = "DSINVADV";

        /// <summary>
        /// DSBATN.
        /// </summary>
        public const string DSBATN = "DSBATN";

        /// <summary>
        /// DSHOLD.
        /// </summary>
        public const string DSHOLD = "DSHOLD";

        /// <summary>
        /// DSDTAI.
        /// </summary>
        public const string DSDTAI = "DSDTAI";
    }

    /// <inheritdoc />
    public override string TableName => "F40R30WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSCTID", "DSCTID", JdeDataType.String, 30, true, true),
        new JdeField("DSJOBS", "DSJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("DSDEID", "DSDEID", JdeDataType.Numeric, null, true, true),
        new JdeField("DSCRTSOCL", "DSCRTSOCL", JdeDataType.String, 2),
        new JdeField("DSSOACTION", "DSSOACTION", JdeDataType.String, 2),
        new JdeField("DSHOLDORD", "DSHOLDORD", JdeDataType.String, 2),
        new JdeField("DSSOLSTS", "DSSOLSTS", JdeDataType.String, 2, true, true),
        new JdeField("DSRRCD", "DSRRCD", JdeDataType.String, 4),
        new JdeField("DSSOSTSNTF", "DSSOSTSNTF", JdeDataType.String, 2),
        new JdeField("DSDOCO", "DSDOCO", JdeDataType.Numeric),
        new JdeField("DSDCTO", "DSDCTO", JdeDataType.String, 4),
        new JdeField("DSKCOO", "DSKCOO", JdeDataType.String, 10),
        new JdeField("DSLNID", "DSLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DSMCU", "DSMCU", JdeDataType.String, 24),
        new JdeField("DSAN8", "DSAN8", JdeDataType.Numeric),
        new JdeField("DSSHAN", "DSSHAN", JdeDataType.Numeric),
        new JdeField("DSITM", "DSITM", JdeDataType.Numeric),
        new JdeField("DSRQSHPQTY", "DSRQSHPQTY", JdeDataType.Numeric),
        new JdeField("DSUOM", "DSUOM", JdeDataType.String, 4),
        new JdeField("DSRSDJ", "DSRSDJ", JdeDataType.Numeric),
        new JdeField("DSRSDT", "DSRSDT", JdeDataType.Numeric),
        new JdeField("DSSOBCKORD", "DSSOBCKORD", JdeDataType.String, 2),
        new JdeField("DSBQNC", "DSBQNC", JdeDataType.Numeric),
        new JdeField("DSINVADV", "DSINVADV", JdeDataType.String, 2),
        new JdeField("DSBATN", "DSBATN", JdeDataType.String, 60),
        new JdeField("DSHOLD", "DSHOLD", JdeDataType.String, 4),
        new JdeField("DSDTAI", "DSDTAI", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R30WF_0", "Primary Key on DSCTID, DSJOBS, DSDEID, DSSOLSTS, DSLNID", new[] { "DSCTID", "DSJOBS", "DSDEID", "DSSOLSTS", "DSLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40R30WF_2", "Index on DSCTID, DSJOBS", new[] { "DSCTID", "DSJOBS" })
    };
}
