using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N161P - .
/// </summary>
public class FD3N161P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHDCT.
        /// </summary>
        public const string PHDCT = "PHDCT";

        /// <summary>
        /// PHPTUPDTTM.
        /// </summary>
        public const string PHPTUPDTTM = "PHPTUPDTTM";

        /// <summary>
        /// PHCNID.
        /// </summary>
        public const string PHCNID = "PHCNID";

        /// <summary>
        /// PHITM.
        /// </summary>
        public const string PHITM = "PHITM";

        /// <summary>
        /// PHLOTN.
        /// </summary>
        public const string PHLOTN = "PHLOTN";

        /// <summary>
        /// PHTRQT.
        /// </summary>
        public const string PHTRQT = "PHTRQT";

        /// <summary>
        /// PHLOCN.
        /// </summary>
        public const string PHLOCN = "PHLOCN";

        /// <summary>
        /// PHSTA.
        /// </summary>
        public const string PHSTA = "PHSTA";

        /// <summary>
        /// PHDOCO.
        /// </summary>
        public const string PHDOCO = "PHDOCO";

        /// <summary>
        /// PHDCTO.
        /// </summary>
        public const string PHDCTO = "PHDCTO";

        /// <summary>
        /// PHAN8.
        /// </summary>
        public const string PHAN8 = "PHAN8";

        /// <summary>
        /// PHMCU.
        /// </summary>
        public const string PHMCU = "PHMCU";

        /// <summary>
        /// PHPTUPUSER.
        /// </summary>
        public const string PHPTUPUSER = "PHPTUPUSER";

        /// <summary>
        /// PHPTDEVICE.
        /// </summary>
        public const string PHPTDEVICE = "PHPTDEVICE";

        /// <summary>
        /// PHNNBR.
        /// </summary>
        public const string PHNNBR = "PHNNBR";

        /// <summary>
        /// PHRCD.
        /// </summary>
        public const string PHRCD = "PHRCD";

        /// <summary>
        /// PHUOM.
        /// </summary>
        public const string PHUOM = "PHUOM";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N161P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHDCT", "PHDCT", JdeDataType.String, 4),
        new JdeField("PHPTUPDTTM", "PHPTUPDTTM", JdeDataType.String, 28),
        new JdeField("PHCNID", "PHCNID", JdeDataType.String, 40),
        new JdeField("PHITM", "PHITM", JdeDataType.Numeric),
        new JdeField("PHLOTN", "PHLOTN", JdeDataType.String, 60),
        new JdeField("PHTRQT", "PHTRQT", JdeDataType.Numeric),
        new JdeField("PHLOCN", "PHLOCN", JdeDataType.String, 40),
        new JdeField("PHSTA", "PHSTA", JdeDataType.String, 2),
        new JdeField("PHDOCO", "PHDOCO", JdeDataType.Numeric),
        new JdeField("PHDCTO", "PHDCTO", JdeDataType.String, 4),
        new JdeField("PHAN8", "PHAN8", JdeDataType.Numeric),
        new JdeField("PHMCU", "PHMCU", JdeDataType.String, 24),
        new JdeField("PHPTUPUSER", "PHPTUPUSER", JdeDataType.String, 32),
        new JdeField("PHPTDEVICE", "PHPTDEVICE", JdeDataType.String, 20),
        new JdeField("PHNNBR", "PHNNBR", JdeDataType.Numeric, null, true, true),
        new JdeField("PHRCD", "PHRCD", JdeDataType.String, 6),
        new JdeField("PHUOM", "PHUOM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N161P_0", "Primary Key on PHNNBR", new[] { "PHNNBR" }, isUnique: true, isPrimaryKey: true)
    };
}
