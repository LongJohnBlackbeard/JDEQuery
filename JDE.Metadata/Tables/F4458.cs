using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4458 - .
/// </summary>
public class F4458 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JKCTYC.
        /// </summary>
        public const string JKCTYC = "JKCTYC";

        /// <summary>
        /// JKMCU.
        /// </summary>
        public const string JKMCU = "JKMCU";

        /// <summary>
        /// JKLITM.
        /// </summary>
        public const string JKLITM = "JKLITM";

        /// <summary>
        /// JKITM.
        /// </summary>
        public const string JKITM = "JKITM";

        /// <summary>
        /// JKPL.
        /// </summary>
        public const string JKPL = "JKPL";

        /// <summary>
        /// JKELEV.
        /// </summary>
        public const string JKELEV = "JKELEV";

        /// <summary>
        /// JKSWG.
        /// </summary>
        public const string JKSWG = "JKSWG";

        /// <summary>
        /// JKOPTN.
        /// </summary>
        public const string JKOPTN = "JKOPTN";

        /// <summary>
        /// JKOBJ.
        /// </summary>
        public const string JKOBJ = "JKOBJ";

        /// <summary>
        /// JKSUB.
        /// </summary>
        public const string JKSUB = "JKSUB";

        /// <summary>
        /// JKUORG.
        /// </summary>
        public const string JKUORG = "JKUORG";

        /// <summary>
        /// JKSITM.
        /// </summary>
        public const string JKSITM = "JKSITM";

        /// <summary>
        /// JKSQFT.
        /// </summary>
        public const string JKSQFT = "JKSQFT";

        /// <summary>
        /// JKENTJ.
        /// </summary>
        public const string JKENTJ = "JKENTJ";

        /// <summary>
        /// JKDGCG.
        /// </summary>
        public const string JKDGCG = "JKDGCG";

        /// <summary>
        /// JKRCD.
        /// </summary>
        public const string JKRCD = "JKRCD";

        /// <summary>
        /// JKDL01.
        /// </summary>
        public const string JKDL01 = "JKDL01";

        /// <summary>
        /// JKTORF.
        /// </summary>
        public const string JKTORF = "JKTORF";

        /// <summary>
        /// JKITMS.
        /// </summary>
        public const string JKITMS = "JKITMS";

        /// <summary>
        /// JKSLKF.
        /// </summary>
        public const string JKSLKF = "JKSLKF";

        /// <summary>
        /// JKUPMJ.
        /// </summary>
        public const string JKUPMJ = "JKUPMJ";

        /// <summary>
        /// JKUSER.
        /// </summary>
        public const string JKUSER = "JKUSER";

        /// <summary>
        /// JKPID.
        /// </summary>
        public const string JKPID = "JKPID";

        /// <summary>
        /// JKJOBN.
        /// </summary>
        public const string JKJOBN = "JKJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F4458";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JKCTYC", "JKCTYC", JdeDataType.String, 6, true, true),
        new JdeField("JKMCU", "JKMCU", JdeDataType.String, 24),
        new JdeField("JKLITM", "JKLITM", JdeDataType.String, 50),
        new JdeField("JKITM", "JKITM", JdeDataType.Numeric),
        new JdeField("JKPL", "JKPL", JdeDataType.String, 8, true, true),
        new JdeField("JKELEV", "JKELEV", JdeDataType.String, 6),
        new JdeField("JKSWG", "JKSWG", JdeDataType.String, 2),
        new JdeField("JKOPTN", "JKOPTN", JdeDataType.String, 16),
        new JdeField("JKOBJ", "JKOBJ", JdeDataType.String, 12),
        new JdeField("JKSUB", "JKSUB", JdeDataType.String, 16),
        new JdeField("JKUORG", "JKUORG", JdeDataType.Numeric),
        new JdeField("JKSITM", "JKSITM", JdeDataType.String, 16),
        new JdeField("JKSQFT", "JKSQFT", JdeDataType.Numeric),
        new JdeField("JKENTJ", "JKENTJ", JdeDataType.Numeric),
        new JdeField("JKDGCG", "JKDGCG", JdeDataType.Numeric),
        new JdeField("JKRCD", "JKRCD", JdeDataType.String, 6),
        new JdeField("JKDL01", "JKDL01", JdeDataType.String, 60),
        new JdeField("JKTORF", "JKTORF", JdeDataType.Numeric, null, true, true),
        new JdeField("JKITMS", "JKITMS", JdeDataType.String, 2),
        new JdeField("JKSLKF", "JKSLKF", JdeDataType.String, 2),
        new JdeField("JKUPMJ", "JKUPMJ", JdeDataType.Numeric),
        new JdeField("JKUSER", "JKUSER", JdeDataType.String, 20),
        new JdeField("JKPID", "JKPID", JdeDataType.String, 20),
        new JdeField("JKJOBN", "JKJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4458_0", "Primary Key on JKCTYC, JKPL, JKTORF", new[] { "JKCTYC", "JKPL", "JKTORF" }, isUnique: true, isPrimaryKey: true)
    };
}
