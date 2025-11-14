using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4457 - .
/// </summary>
public class F4457 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JJCTYC.
        /// </summary>
        public const string JJCTYC = "JJCTYC";

        /// <summary>
        /// JJMCU.
        /// </summary>
        public const string JJMCU = "JJMCU";

        /// <summary>
        /// JJLITM.
        /// </summary>
        public const string JJLITM = "JJLITM";

        /// <summary>
        /// JJITM.
        /// </summary>
        public const string JJITM = "JJITM";

        /// <summary>
        /// JJPL.
        /// </summary>
        public const string JJPL = "JJPL";

        /// <summary>
        /// JJELEV.
        /// </summary>
        public const string JJELEV = "JJELEV";

        /// <summary>
        /// JJSWG.
        /// </summary>
        public const string JJSWG = "JJSWG";

        /// <summary>
        /// JJOPTN.
        /// </summary>
        public const string JJOPTN = "JJOPTN";

        /// <summary>
        /// JJOBJ.
        /// </summary>
        public const string JJOBJ = "JJOBJ";

        /// <summary>
        /// JJSUB.
        /// </summary>
        public const string JJSUB = "JJSUB";

        /// <summary>
        /// JJUORG.
        /// </summary>
        public const string JJUORG = "JJUORG";

        /// <summary>
        /// JJSITM.
        /// </summary>
        public const string JJSITM = "JJSITM";

        /// <summary>
        /// JJSQFT.
        /// </summary>
        public const string JJSQFT = "JJSQFT";

        /// <summary>
        /// JJENTJ.
        /// </summary>
        public const string JJENTJ = "JJENTJ";

        /// <summary>
        /// JJDGCG.
        /// </summary>
        public const string JJDGCG = "JJDGCG";

        /// <summary>
        /// JJRCD.
        /// </summary>
        public const string JJRCD = "JJRCD";

        /// <summary>
        /// JJDL01.
        /// </summary>
        public const string JJDL01 = "JJDL01";

        /// <summary>
        /// JJTORF.
        /// </summary>
        public const string JJTORF = "JJTORF";

        /// <summary>
        /// JJITMS.
        /// </summary>
        public const string JJITMS = "JJITMS";

        /// <summary>
        /// JJSLKF.
        /// </summary>
        public const string JJSLKF = "JJSLKF";

        /// <summary>
        /// JJUPMJ.
        /// </summary>
        public const string JJUPMJ = "JJUPMJ";

        /// <summary>
        /// JJUSER.
        /// </summary>
        public const string JJUSER = "JJUSER";

        /// <summary>
        /// JJPID.
        /// </summary>
        public const string JJPID = "JJPID";

        /// <summary>
        /// JJJOBN.
        /// </summary>
        public const string JJJOBN = "JJJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F4457";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JJCTYC", "JJCTYC", JdeDataType.String, 6, true, true),
        new JdeField("JJMCU", "JJMCU", JdeDataType.String, 24, true, true),
        new JdeField("JJLITM", "JJLITM", JdeDataType.String, 50, true, true),
        new JdeField("JJITM", "JJITM", JdeDataType.Numeric),
        new JdeField("JJPL", "JJPL", JdeDataType.String, 8, true, true),
        new JdeField("JJELEV", "JJELEV", JdeDataType.String, 6, true, true),
        new JdeField("JJSWG", "JJSWG", JdeDataType.String, 2, true, true),
        new JdeField("JJOPTN", "JJOPTN", JdeDataType.String, 16, true, true),
        new JdeField("JJOBJ", "JJOBJ", JdeDataType.String, 12),
        new JdeField("JJSUB", "JJSUB", JdeDataType.String, 16, true, true),
        new JdeField("JJUORG", "JJUORG", JdeDataType.Numeric),
        new JdeField("JJSITM", "JJSITM", JdeDataType.String, 16),
        new JdeField("JJSQFT", "JJSQFT", JdeDataType.Numeric),
        new JdeField("JJENTJ", "JJENTJ", JdeDataType.Numeric),
        new JdeField("JJDGCG", "JJDGCG", JdeDataType.Numeric),
        new JdeField("JJRCD", "JJRCD", JdeDataType.String, 6),
        new JdeField("JJDL01", "JJDL01", JdeDataType.String, 60),
        new JdeField("JJTORF", "JJTORF", JdeDataType.Numeric),
        new JdeField("JJITMS", "JJITMS", JdeDataType.String, 2),
        new JdeField("JJSLKF", "JJSLKF", JdeDataType.String, 2),
        new JdeField("JJUPMJ", "JJUPMJ", JdeDataType.Numeric),
        new JdeField("JJUSER", "JJUSER", JdeDataType.String, 20),
        new JdeField("JJPID", "JJPID", JdeDataType.String, 20),
        new JdeField("JJJOBN", "JJJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4457_0", "Primary Key on JJCTYC, JJPL, JJMCU, JJELEV, JJSWG, JJOPTN, JJLITM, JJSUB", new[] { "JJCTYC", "JJPL", "JJMCU", "JJELEV", "JJSWG", "JJOPTN", "JJLITM", "JJSUB" }, isUnique: true, isPrimaryKey: true)
    };
}
