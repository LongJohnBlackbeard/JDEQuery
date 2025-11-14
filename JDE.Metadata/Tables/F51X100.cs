using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51X100 - .
/// </summary>
public class F51X100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AR51XARN.
        /// </summary>
        public const string AR51XARN = "AR51XARN";

        /// <summary>
        /// ARDL01.
        /// </summary>
        public const string ARDL01 = "ARDL01";

        /// <summary>
        /// AR51XCCCT.
        /// </summary>
        public const string AR51XCCCT = "AR51XCCCT";

        /// <summary>
        /// ARSEQ.
        /// </summary>
        public const string ARSEQ = "ARSEQ";

        /// <summary>
        /// ARFSUB.
        /// </summary>
        public const string ARFSUB = "ARFSUB";

        /// <summary>
        /// ARSUBT.
        /// </summary>
        public const string ARSUBT = "ARSUBT";

        /// <summary>
        /// AROBJF.
        /// </summary>
        public const string AROBJF = "AROBJF";

        /// <summary>
        /// AROBJT.
        /// </summary>
        public const string AROBJT = "AROBJT";

        /// <summary>
        /// ARJOBN.
        /// </summary>
        public const string ARJOBN = "ARJOBN";

        /// <summary>
        /// ARPID.
        /// </summary>
        public const string ARPID = "ARPID";

        /// <summary>
        /// ARUSER.
        /// </summary>
        public const string ARUSER = "ARUSER";

        /// <summary>
        /// ARUPMJ.
        /// </summary>
        public const string ARUPMJ = "ARUPMJ";

        /// <summary>
        /// ARUPMT.
        /// </summary>
        public const string ARUPMT = "ARUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F51X100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AR51XARN", "AR51XARN", JdeDataType.String, 12, true, true),
        new JdeField("ARDL01", "ARDL01", JdeDataType.String, 60),
        new JdeField("AR51XCCCT", "AR51XCCCT", JdeDataType.String, 2),
        new JdeField("ARSEQ", "ARSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ARFSUB", "ARFSUB", JdeDataType.String, 16),
        new JdeField("ARSUBT", "ARSUBT", JdeDataType.String, 16),
        new JdeField("AROBJF", "AROBJF", JdeDataType.String, 12),
        new JdeField("AROBJT", "AROBJT", JdeDataType.String, 12),
        new JdeField("ARJOBN", "ARJOBN", JdeDataType.String, 20),
        new JdeField("ARPID", "ARPID", JdeDataType.String, 20),
        new JdeField("ARUSER", "ARUSER", JdeDataType.String, 20),
        new JdeField("ARUPMJ", "ARUPMJ", JdeDataType.Numeric),
        new JdeField("ARUPMT", "ARUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51X100_0", "Primary Key on AR51XARN, ARSEQ", new[] { "AR51XARN", "ARSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
