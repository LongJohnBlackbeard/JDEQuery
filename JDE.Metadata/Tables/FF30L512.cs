using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L512 - .
/// </summary>
public class FF30L512 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UMDFMCU.
        /// </summary>
        public const string UMDFMCU = "UMDFMCU";

        /// <summary>
        /// UMDFITM.
        /// </summary>
        public const string UMDFITM = "UMDFITM";

        /// <summary>
        /// UMFSCID.
        /// </summary>
        public const string UMFSCID = "UMFSCID";

        /// <summary>
        /// UMUM.
        /// </summary>
        public const string UMUM = "UMUM";

        /// <summary>
        /// UMRUM.
        /// </summary>
        public const string UMRUM = "UMRUM";

        /// <summary>
        /// UMUSTR.
        /// </summary>
        public const string UMUSTR = "UMUSTR";

        /// <summary>
        /// UMCONV.
        /// </summary>
        public const string UMCONV = "UMCONV";

        /// <summary>
        /// UMCNV1.
        /// </summary>
        public const string UMCNV1 = "UMCNV1";

        /// <summary>
        /// UMUSER.
        /// </summary>
        public const string UMUSER = "UMUSER";

        /// <summary>
        /// UMPID.
        /// </summary>
        public const string UMPID = "UMPID";

        /// <summary>
        /// UMMKEY.
        /// </summary>
        public const string UMMKEY = "UMMKEY";

        /// <summary>
        /// UMUUPMJ.
        /// </summary>
        public const string UMUUPMJ = "UMUUPMJ";

        /// <summary>
        /// UMEXPO.
        /// </summary>
        public const string UMEXPO = "UMEXPO";

        /// <summary>
        /// UMEXSO.
        /// </summary>
        public const string UMEXSO = "UMEXSO";

        /// <summary>
        /// UMPUPC.
        /// </summary>
        public const string UMPUPC = "UMPUPC";

        /// <summary>
        /// UMURCD.
        /// </summary>
        public const string UMURCD = "UMURCD";

        /// <summary>
        /// UMURDT.
        /// </summary>
        public const string UMURDT = "UMURDT";

        /// <summary>
        /// UMURAT.
        /// </summary>
        public const string UMURAT = "UMURAT";

        /// <summary>
        /// UMURAB.
        /// </summary>
        public const string UMURAB = "UMURAB";

        /// <summary>
        /// UMURRF.
        /// </summary>
        public const string UMURRF = "UMURRF";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L512";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UMDFMCU", "UMDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("UMDFITM", "UMDFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("UMFSCID", "UMFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("UMUM", "UMUM", JdeDataType.String, 4, true, true),
        new JdeField("UMRUM", "UMRUM", JdeDataType.String, 4, true, true),
        new JdeField("UMUSTR", "UMUSTR", JdeDataType.String, 2),
        new JdeField("UMCONV", "UMCONV", JdeDataType.Numeric),
        new JdeField("UMCNV1", "UMCNV1", JdeDataType.Numeric),
        new JdeField("UMUSER", "UMUSER", JdeDataType.String, 20),
        new JdeField("UMPID", "UMPID", JdeDataType.String, 20),
        new JdeField("UMMKEY", "UMMKEY", JdeDataType.String, 30),
        new JdeField("UMUUPMJ", "UMUUPMJ", JdeDataType.Date),
        new JdeField("UMEXPO", "UMEXPO", JdeDataType.String, 2),
        new JdeField("UMEXSO", "UMEXSO", JdeDataType.String, 2),
        new JdeField("UMPUPC", "UMPUPC", JdeDataType.Numeric),
        new JdeField("UMURCD", "UMURCD", JdeDataType.String, 4),
        new JdeField("UMURDT", "UMURDT", JdeDataType.Numeric),
        new JdeField("UMURAT", "UMURAT", JdeDataType.Numeric),
        new JdeField("UMURAB", "UMURAB", JdeDataType.Numeric),
        new JdeField("UMURRF", "UMURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L512_0", "Primary Key on UMFSCID, UMDFITM, UMDFMCU, UMUM, UMRUM", new[] { "UMFSCID", "UMDFITM", "UMDFMCU", "UMUM", "UMRUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L512_2", "Index on UMFSCID, UMDFMCU, UMDFITM, UMUM, UMRUM", new[] { "UMFSCID", "UMDFMCU", "UMDFITM", "UMUM", "UMRUM" }),
        new JdeIndex("FF30L512_3", "Index on UMFSCID", new[] { "UMFSCID" })
    };
}
