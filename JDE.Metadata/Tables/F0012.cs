using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0012 - .
/// </summary>
public class F0012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KGITEM.
        /// </summary>
        public const string KGITEM = "KGITEM";

        /// <summary>
        /// KGCO.
        /// </summary>
        public const string KGCO = "KGCO";

        /// <summary>
        /// KGMCU.
        /// </summary>
        public const string KGMCU = "KGMCU";

        /// <summary>
        /// KGOBJ.
        /// </summary>
        public const string KGOBJ = "KGOBJ";

        /// <summary>
        /// KGSUB.
        /// </summary>
        public const string KGSUB = "KGSUB";

        /// <summary>
        /// KGDL01.
        /// </summary>
        public const string KGDL01 = "KGDL01";

        /// <summary>
        /// KGDL02.
        /// </summary>
        public const string KGDL02 = "KGDL02";

        /// <summary>
        /// KGDL03.
        /// </summary>
        public const string KGDL03 = "KGDL03";

        /// <summary>
        /// KGDL04.
        /// </summary>
        public const string KGDL04 = "KGDL04";

        /// <summary>
        /// KGDL05.
        /// </summary>
        public const string KGDL05 = "KGDL05";

        /// <summary>
        /// KGMOPT.
        /// </summary>
        public const string KGMOPT = "KGMOPT";

        /// <summary>
        /// KGOOPT.
        /// </summary>
        public const string KGOOPT = "KGOOPT";

        /// <summary>
        /// KGSOPT.
        /// </summary>
        public const string KGSOPT = "KGSOPT";

        /// <summary>
        /// KGSY.
        /// </summary>
        public const string KGSY = "KGSY";

        /// <summary>
        /// KGSEQN.
        /// </summary>
        public const string KGSEQN = "KGSEQN";

        /// <summary>
        /// KGUSER.
        /// </summary>
        public const string KGUSER = "KGUSER";

        /// <summary>
        /// KGPID.
        /// </summary>
        public const string KGPID = "KGPID";

        /// <summary>
        /// KGUPMJ.
        /// </summary>
        public const string KGUPMJ = "KGUPMJ";

        /// <summary>
        /// KGJOBN.
        /// </summary>
        public const string KGJOBN = "KGJOBN";

        /// <summary>
        /// KGUPMT.
        /// </summary>
        public const string KGUPMT = "KGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KGITEM", "KGITEM", JdeDataType.String, 12, true, true),
        new JdeField("KGCO", "KGCO", JdeDataType.String, 10, true, true),
        new JdeField("KGMCU", "KGMCU", JdeDataType.String, 24),
        new JdeField("KGOBJ", "KGOBJ", JdeDataType.String, 12),
        new JdeField("KGSUB", "KGSUB", JdeDataType.String, 16),
        new JdeField("KGDL01", "KGDL01", JdeDataType.String, 60),
        new JdeField("KGDL02", "KGDL02", JdeDataType.String, 60),
        new JdeField("KGDL03", "KGDL03", JdeDataType.String, 60),
        new JdeField("KGDL04", "KGDL04", JdeDataType.String, 60),
        new JdeField("KGDL05", "KGDL05", JdeDataType.String, 60),
        new JdeField("KGMOPT", "KGMOPT", JdeDataType.String, 2),
        new JdeField("KGOOPT", "KGOOPT", JdeDataType.String, 2),
        new JdeField("KGSOPT", "KGSOPT", JdeDataType.String, 2),
        new JdeField("KGSY", "KGSY", JdeDataType.String, 8),
        new JdeField("KGSEQN", "KGSEQN", JdeDataType.Numeric),
        new JdeField("KGUSER", "KGUSER", JdeDataType.String, 20),
        new JdeField("KGPID", "KGPID", JdeDataType.String, 20),
        new JdeField("KGUPMJ", "KGUPMJ", JdeDataType.Numeric),
        new JdeField("KGJOBN", "KGJOBN", JdeDataType.String, 20),
        new JdeField("KGUPMT", "KGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0012_0", "Primary Key on KGITEM, KGCO", new[] { "KGITEM", "KGCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0012_2", "Unique Index on KGSEQN, KGITEM, KGCO", new[] { "KGSEQN", "KGITEM", "KGCO" }, isUnique: true)
    };
}
