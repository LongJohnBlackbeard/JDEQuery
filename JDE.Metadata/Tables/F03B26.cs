using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B26 - .
/// </summary>
public class F03B26 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RLPLY.
        /// </summary>
        public const string RLPLY = "RLPLY";

        /// <summary>
        /// RLLNID.
        /// </summary>
        public const string RLLNID = "RLLNID";

        /// <summary>
        /// RLAGC.
        /// </summary>
        public const string RLAGC = "RLAGC";

        /// <summary>
        /// RLTHP.
        /// </summary>
        public const string RLTHP = "RLTHP";

        /// <summary>
        /// RLMINP.
        /// </summary>
        public const string RLMINP = "RLMINP";

        /// <summary>
        /// RLLTNA.
        /// </summary>
        public const string RLLTNA = "RLLTNA";

        /// <summary>
        /// RLLTTY.
        /// </summary>
        public const string RLLTTY = "RLLTTY";

        /// <summary>
        /// RLSTCL.
        /// </summary>
        public const string RLSTCL = "RLSTCL";

        /// <summary>
        /// RLCMAR.
        /// </summary>
        public const string RLCMAR = "RLCMAR";

        /// <summary>
        /// RLNTCM.
        /// </summary>
        public const string RLNTCM = "RLNTCM";

        /// <summary>
        /// RLDELD.
        /// </summary>
        public const string RLDELD = "RLDELD";

        /// <summary>
        /// RLCRCD.
        /// </summary>
        public const string RLCRCD = "RLCRCD";

        /// <summary>
        /// RLMACL.
        /// </summary>
        public const string RLMACL = "RLMACL";

        /// <summary>
        /// RLTSTA.
        /// </summary>
        public const string RLTSTA = "RLTSTA";

        /// <summary>
        /// RLHDAR.
        /// </summary>
        public const string RLHDAR = "RLHDAR";

        /// <summary>
        /// RLAIPR.
        /// </summary>
        public const string RLAIPR = "RLAIPR";

        /// <summary>
        /// RLUSER.
        /// </summary>
        public const string RLUSER = "RLUSER";

        /// <summary>
        /// RLPID.
        /// </summary>
        public const string RLPID = "RLPID";

        /// <summary>
        /// RLJOBN.
        /// </summary>
        public const string RLJOBN = "RLJOBN";

        /// <summary>
        /// RLUPMJ.
        /// </summary>
        public const string RLUPMJ = "RLUPMJ";

        /// <summary>
        /// RLUPMT.
        /// </summary>
        public const string RLUPMT = "RLUPMT";

        /// <summary>
        /// RLGPD.
        /// </summary>
        public const string RLGPD = "RLGPD";

        /// <summary>
        /// RLPBDY.
        /// </summary>
        public const string RLPBDY = "RLPBDY";

        /// <summary>
        /// RLCSUM.
        /// </summary>
        public const string RLCSUM = "RLCSUM";
    }

    /// <inheritdoc />
    public override string TableName => "F03B26";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RLPLY", "RLPLY", JdeDataType.Numeric, null, true, true),
        new JdeField("RLLNID", "RLLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RLAGC", "RLAGC", JdeDataType.String, 2),
        new JdeField("RLTHP", "RLTHP", JdeDataType.Numeric),
        new JdeField("RLMINP", "RLMINP", JdeDataType.Numeric),
        new JdeField("RLLTNA", "RLLTNA", JdeDataType.String, 20),
        new JdeField("RLLTTY", "RLLTTY", JdeDataType.String, 2),
        new JdeField("RLSTCL", "RLSTCL", JdeDataType.String, 2),
        new JdeField("RLCMAR", "RLCMAR", JdeDataType.String, 2),
        new JdeField("RLNTCM", "RLNTCM", JdeDataType.String, 2),
        new JdeField("RLDELD", "RLDELD", JdeDataType.Numeric),
        new JdeField("RLCRCD", "RLCRCD", JdeDataType.String, 6),
        new JdeField("RLMACL", "RLMACL", JdeDataType.String, 2),
        new JdeField("RLTSTA", "RLTSTA", JdeDataType.String, 4),
        new JdeField("RLHDAR", "RLHDAR", JdeDataType.String, 2),
        new JdeField("RLAIPR", "RLAIPR", JdeDataType.String, 2),
        new JdeField("RLUSER", "RLUSER", JdeDataType.String, 20),
        new JdeField("RLPID", "RLPID", JdeDataType.String, 20),
        new JdeField("RLJOBN", "RLJOBN", JdeDataType.String, 20),
        new JdeField("RLUPMJ", "RLUPMJ", JdeDataType.Numeric),
        new JdeField("RLUPMT", "RLUPMT", JdeDataType.Numeric),
        new JdeField("RLGPD", "RLGPD", JdeDataType.Numeric),
        new JdeField("RLPBDY", "RLPBDY", JdeDataType.Numeric),
        new JdeField("RLCSUM", "RLCSUM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B26_0", "Primary Key on RLPLY, RLLNID", new[] { "RLPLY", "RLLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B26_2", "Index on RLLTNA, RLLTTY, RLPLY, RLLNID", new[] { "RLLTNA", "RLLTTY", "RLPLY", "RLLNID" })
    };
}
