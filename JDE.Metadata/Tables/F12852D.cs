using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12852D - .
/// </summary>
public class F12852D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LVADM.
        /// </summary>
        public const string LVADM = "LVADM";

        /// <summary>
        /// LVADLM.
        /// </summary>
        public const string LVADLM = "LVADLM";

        /// <summary>
        /// LVITAC.
        /// </summary>
        public const string LVITAC = "LVITAC";

        /// <summary>
        /// LVDIR1.
        /// </summary>
        public const string LVDIR1 = "LVDIR1";

        /// <summary>
        /// LVDTFR.
        /// </summary>
        public const string LVDTFR = "LVDTFR";

        /// <summary>
        /// LVEFTB.
        /// </summary>
        public const string LVEFTB = "LVEFTB";

        /// <summary>
        /// LVLYFR.
        /// </summary>
        public const string LVLYFR = "LVLYFR";

        /// <summary>
        /// LVPISP.
        /// </summary>
        public const string LVPISP = "LVPISP";

        /// <summary>
        /// LVSPCN.
        /// </summary>
        public const string LVSPCN = "LVSPCN";

        /// <summary>
        /// LVLYTO.
        /// </summary>
        public const string LVLYTO = "LVLYTO";

        /// <summary>
        /// LVANMP.
        /// </summary>
        public const string LVANMP = "LVANMP";

        /// <summary>
        /// LVFORD.
        /// </summary>
        public const string LVFORD = "LVFORD";

        /// <summary>
        /// LVFORB.
        /// </summary>
        public const string LVFORB = "LVFORB";

        /// <summary>
        /// LVFORS.
        /// </summary>
        public const string LVFORS = "LVFORS";

        /// <summary>
        /// LVFORU.
        /// </summary>
        public const string LVFORU = "LVFORU";

        /// <summary>
        /// LVFORL.
        /// </summary>
        public const string LVFORL = "LVFORL";

        /// <summary>
        /// LVPSPC.
        /// </summary>
        public const string LVPSPC = "LVPSPC";

        /// <summary>
        /// LVLCT.
        /// </summary>
        public const string LVLCT = "LVLCT";

        /// <summary>
        /// LVUSER.
        /// </summary>
        public const string LVUSER = "LVUSER";

        /// <summary>
        /// LVPID.
        /// </summary>
        public const string LVPID = "LVPID";

        /// <summary>
        /// LVUPMJ.
        /// </summary>
        public const string LVUPMJ = "LVUPMJ";

        /// <summary>
        /// LVJOBN.
        /// </summary>
        public const string LVJOBN = "LVJOBN";

        /// <summary>
        /// LVUPMT.
        /// </summary>
        public const string LVUPMT = "LVUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F12852D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LVADM", "LVADM", JdeDataType.String, 4, true, true),
        new JdeField("LVADLM", "LVADLM", JdeDataType.Numeric, null, true, true),
        new JdeField("LVITAC", "LVITAC", JdeDataType.String, 2, true, true),
        new JdeField("LVDIR1", "LVDIR1", JdeDataType.String, 2, true, true),
        new JdeField("LVDTFR", "LVDTFR", JdeDataType.Numeric, null, true, true),
        new JdeField("LVEFTB", "LVEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("LVLYFR", "LVLYFR", JdeDataType.Numeric, null, true, true),
        new JdeField("LVPISP", "LVPISP", JdeDataType.Numeric, null, true, true),
        new JdeField("LVSPCN", "LVSPCN", JdeDataType.String, 2, true, true),
        new JdeField("LVLYTO", "LVLYTO", JdeDataType.Numeric),
        new JdeField("LVANMP", "LVANMP", JdeDataType.Numeric),
        new JdeField("LVFORD", "LVFORD", JdeDataType.String, 6),
        new JdeField("LVFORB", "LVFORB", JdeDataType.String, 6),
        new JdeField("LVFORS", "LVFORS", JdeDataType.String, 6),
        new JdeField("LVFORU", "LVFORU", JdeDataType.String, 6),
        new JdeField("LVFORL", "LVFORL", JdeDataType.String, 6),
        new JdeField("LVPSPC", "LVPSPC", JdeDataType.String, 6),
        new JdeField("LVLCT", "LVLCT", JdeDataType.Numeric),
        new JdeField("LVUSER", "LVUSER", JdeDataType.String, 20),
        new JdeField("LVPID", "LVPID", JdeDataType.String, 20),
        new JdeField("LVUPMJ", "LVUPMJ", JdeDataType.Numeric),
        new JdeField("LVJOBN", "LVJOBN", JdeDataType.String, 20),
        new JdeField("LVUPMT", "LVUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12852D_0", "Primary Key on LVADM, LVADLM, LVITAC, LVDIR1, LVDTFR, LVEFTB, LVLYFR, LVPISP, LVSPCN", new[] { "LVADM", "LVADLM", "LVITAC", "LVDIR1", "LVDTFR", "LVEFTB", "LVLYFR", "LVPISP", "LVSPCN" }, isUnique: true, isPrimaryKey: true)
    };
}
