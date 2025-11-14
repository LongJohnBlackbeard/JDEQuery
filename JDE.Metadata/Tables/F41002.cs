using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41002 - .
/// </summary>
public class F41002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UMMCU.
        /// </summary>
        public const string UMMCU = "UMMCU";

        /// <summary>
        /// UMITM.
        /// </summary>
        public const string UMITM = "UMITM";

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
        /// UMJOBN.
        /// </summary>
        public const string UMJOBN = "UMJOBN";

        /// <summary>
        /// UMUPMJ.
        /// </summary>
        public const string UMUPMJ = "UMUPMJ";

        /// <summary>
        /// UMTDAY.
        /// </summary>
        public const string UMTDAY = "UMTDAY";

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
        /// UMSEPC.
        /// </summary>
        public const string UMSEPC = "UMSEPC";
    }

    /// <inheritdoc />
    public override string TableName => "F41002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UMMCU", "UMMCU", JdeDataType.String, 24, true, true),
        new JdeField("UMITM", "UMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("UMUM", "UMUM", JdeDataType.String, 4, true, true),
        new JdeField("UMRUM", "UMRUM", JdeDataType.String, 4, true, true),
        new JdeField("UMUSTR", "UMUSTR", JdeDataType.String, 2),
        new JdeField("UMCONV", "UMCONV", JdeDataType.Numeric),
        new JdeField("UMCNV1", "UMCNV1", JdeDataType.Numeric),
        new JdeField("UMUSER", "UMUSER", JdeDataType.String, 20),
        new JdeField("UMPID", "UMPID", JdeDataType.String, 20),
        new JdeField("UMJOBN", "UMJOBN", JdeDataType.String, 20),
        new JdeField("UMUPMJ", "UMUPMJ", JdeDataType.Numeric),
        new JdeField("UMTDAY", "UMTDAY", JdeDataType.Numeric),
        new JdeField("UMEXPO", "UMEXPO", JdeDataType.String, 2),
        new JdeField("UMEXSO", "UMEXSO", JdeDataType.String, 2),
        new JdeField("UMPUPC", "UMPUPC", JdeDataType.Numeric),
        new JdeField("UMSEPC", "UMSEPC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41002_0", "Primary Key on UMMCU, UMITM, UMUM, UMRUM", new[] { "UMMCU", "UMITM", "UMUM", "UMRUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41002_2", "Index on UMMCU, UMITM, UMUM", new[] { "UMMCU", "UMITM", "UMUM" }),
        new JdeIndex("F41002_3", "Index on UMITM, UMUM, UMRUM", new[] { "UMITM", "UMUM", "UMRUM" }),
        new JdeIndex("F41002_4", "Index on UMITM, UMUM", new[] { "UMITM", "UMUM" }),
        new JdeIndex("F41002_5", "Index on UMITM, UMRUM, UMMCU, UMUM", new[] { "UMITM", "UMRUM", "UMMCU", "UMUM" }),
        new JdeIndex("F41002_7", "Index on UMMCU, UMITM, UMUSTR, UMUM, UMRUM", new[] { "UMMCU", "UMITM", "UMUSTR", "UMUM", "UMRUM" })
    };
}
