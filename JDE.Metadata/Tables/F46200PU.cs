using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46200PU - .
/// </summary>
public class F46200PU : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BRBRBT.
        /// </summary>
        public const string BRBRBT = "BRBRBT";

        /// <summary>
        /// BRBRSN.
        /// </summary>
        public const string BRBRSN = "BRBRSN";

        /// <summary>
        /// BRRQBT.
        /// </summary>
        public const string BRRQBT = "BRRQBT";

        /// <summary>
        /// BRRQSQ.
        /// </summary>
        public const string BRRQSQ = "BRRQSQ";

        /// <summary>
        /// BRMCU.
        /// </summary>
        public const string BRMCU = "BRMCU";

        /// <summary>
        /// BRCNPR.
        /// </summary>
        public const string BRCNPR = "BRCNPR";

        /// <summary>
        /// BRQTRQ.
        /// </summary>
        public const string BRQTRQ = "BRQTRQ";

        /// <summary>
        /// BRUOM.
        /// </summary>
        public const string BRUOM = "BRUOM";

        /// <summary>
        /// BRDOCO.
        /// </summary>
        public const string BRDOCO = "BRDOCO";

        /// <summary>
        /// BRDCTO.
        /// </summary>
        public const string BRDCTO = "BRDCTO";

        /// <summary>
        /// BRKCOO.
        /// </summary>
        public const string BRKCOO = "BRKCOO";

        /// <summary>
        /// BRLNID.
        /// </summary>
        public const string BRLNID = "BRLNID";

        /// <summary>
        /// BRUKID.
        /// </summary>
        public const string BRUKID = "BRUKID";

        /// <summary>
        /// BROCDE.
        /// </summary>
        public const string BROCDE = "BROCDE";

        /// <summary>
        /// BRRLIT.
        /// </summary>
        public const string BRRLIT = "BRRLIT";

        /// <summary>
        /// BRKTLN.
        /// </summary>
        public const string BRKTLN = "BRKTLN";

        /// <summary>
        /// BRLTTR.
        /// </summary>
        public const string BRLTTR = "BRLTTR";

        /// <summary>
        /// BRNXTR.
        /// </summary>
        public const string BRNXTR = "BRNXTR";

        /// <summary>
        /// BRNXT2.
        /// </summary>
        public const string BRNXT2 = "BRNXT2";

        /// <summary>
        /// BRNXTEV1.
        /// </summary>
        public const string BRNXTEV1 = "BRNXTEV1";

        /// <summary>
        /// BRTQTY.
        /// </summary>
        public const string BRTQTY = "BRTQTY";

        /// <summary>
        /// BRQAVAL.
        /// </summary>
        public const string BRQAVAL = "BRQAVAL";

        /// <summary>
        /// BRRAQC.
        /// </summary>
        public const string BRRAQC = "BRRAQC";

        /// <summary>
        /// BRPSTB.
        /// </summary>
        public const string BRPSTB = "BRPSTB";

        /// <summary>
        /// BRKTFG.
        /// </summary>
        public const string BRKTFG = "BRKTFG";

        /// <summary>
        /// BRCARS.
        /// </summary>
        public const string BRCARS = "BRCARS";

        /// <summary>
        /// BRSHPN.
        /// </summary>
        public const string BRSHPN = "BRSHPN";

        /// <summary>
        /// BRVMCU.
        /// </summary>
        public const string BRVMCU = "BRVMCU";

        /// <summary>
        /// BRLDNM.
        /// </summary>
        public const string BRLDNM = "BRLDNM";

        /// <summary>
        /// BRUSER.
        /// </summary>
        public const string BRUSER = "BRUSER";

        /// <summary>
        /// BRPID.
        /// </summary>
        public const string BRPID = "BRPID";

        /// <summary>
        /// BRJOBN.
        /// </summary>
        public const string BRJOBN = "BRJOBN";

        /// <summary>
        /// BRUPMJ.
        /// </summary>
        public const string BRUPMJ = "BRUPMJ";

        /// <summary>
        /// BRTDAY.
        /// </summary>
        public const string BRTDAY = "BRTDAY";

        /// <summary>
        /// BRDTE.
        /// </summary>
        public const string BRDTE = "BRDTE";

        /// <summary>
        /// BRTICU.
        /// </summary>
        public const string BRTICU = "BRTICU";

        /// <summary>
        /// BRSCHUSER.
        /// </summary>
        public const string BRSCHUSER = "BRSCHUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F46200PU";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BRBRBT", "BRBRBT", JdeDataType.Numeric),
        new JdeField("BRBRSN", "BRBRSN", JdeDataType.Numeric),
        new JdeField("BRRQBT", "BRRQBT", JdeDataType.Numeric, null, true, true),
        new JdeField("BRRQSQ", "BRRQSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("BRMCU", "BRMCU", JdeDataType.String, 24, true, true),
        new JdeField("BRCNPR", "BRCNPR", JdeDataType.Numeric),
        new JdeField("BRQTRQ", "BRQTRQ", JdeDataType.Numeric),
        new JdeField("BRUOM", "BRUOM", JdeDataType.String, 4),
        new JdeField("BRDOCO", "BRDOCO", JdeDataType.Numeric),
        new JdeField("BRDCTO", "BRDCTO", JdeDataType.String, 4),
        new JdeField("BRKCOO", "BRKCOO", JdeDataType.String, 10),
        new JdeField("BRLNID", "BRLNID", JdeDataType.Numeric),
        new JdeField("BRUKID", "BRUKID", JdeDataType.Numeric),
        new JdeField("BROCDE", "BROCDE", JdeDataType.String, 4),
        new JdeField("BRRLIT", "BRRLIT", JdeDataType.String, 16),
        new JdeField("BRKTLN", "BRKTLN", JdeDataType.Numeric),
        new JdeField("BRLTTR", "BRLTTR", JdeDataType.String, 6),
        new JdeField("BRNXTR", "BRNXTR", JdeDataType.String, 6),
        new JdeField("BRNXT2", "BRNXT2", JdeDataType.String, 6),
        new JdeField("BRNXTEV1", "BRNXTEV1", JdeDataType.String, 6),
        new JdeField("BRTQTY", "BRTQTY", JdeDataType.Numeric),
        new JdeField("BRQAVAL", "BRQAVAL", JdeDataType.Numeric),
        new JdeField("BRRAQC", "BRRAQC", JdeDataType.Numeric),
        new JdeField("BRPSTB", "BRPSTB", JdeDataType.String, 6),
        new JdeField("BRKTFG", "BRKTFG", JdeDataType.String, 2),
        new JdeField("BRCARS", "BRCARS", JdeDataType.Numeric),
        new JdeField("BRSHPN", "BRSHPN", JdeDataType.Numeric),
        new JdeField("BRVMCU", "BRVMCU", JdeDataType.String, 24),
        new JdeField("BRLDNM", "BRLDNM", JdeDataType.Numeric),
        new JdeField("BRUSER", "BRUSER", JdeDataType.String, 20),
        new JdeField("BRPID", "BRPID", JdeDataType.String, 20),
        new JdeField("BRJOBN", "BRJOBN", JdeDataType.String, 20),
        new JdeField("BRUPMJ", "BRUPMJ", JdeDataType.Numeric),
        new JdeField("BRTDAY", "BRTDAY", JdeDataType.Numeric),
        new JdeField("BRDTE", "BRDTE", JdeDataType.Numeric),
        new JdeField("BRTICU", "BRTICU", JdeDataType.Numeric),
        new JdeField("BRSCHUSER", "BRSCHUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46200PU_0", "Primary Key on BRMCU, BRRQBT, BRRQSQ", new[] { "BRMCU", "BRRQBT", "BRRQSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
