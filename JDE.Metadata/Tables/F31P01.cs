using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31P01 - .
/// </summary>
public class F31P01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PAPRJM.
        /// </summary>
        public const string PAPRJM = "PAPRJM";

        /// <summary>
        /// PAOVEF.
        /// </summary>
        public const string PAOVEF = "PAOVEF";

        /// <summary>
        /// PAJCBU.
        /// </summary>
        public const string PAJCBU = "PAJCBU";

        /// <summary>
        /// PAREAF.
        /// </summary>
        public const string PAREAF = "PAREAF";

        /// <summary>
        /// PALWBS.
        /// </summary>
        public const string PALWBS = "PALWBS";

        /// <summary>
        /// PADOCO.
        /// </summary>
        public const string PADOCO = "PADOCO";

        /// <summary>
        /// PADCTO.
        /// </summary>
        public const string PADCTO = "PADCTO";

        /// <summary>
        /// PAKCOO.
        /// </summary>
        public const string PAKCOO = "PAKCOO";

        /// <summary>
        /// PAQTAF.
        /// </summary>
        public const string PAQTAF = "PAQTAF";

        /// <summary>
        /// PAESFF.
        /// </summary>
        public const string PAESFF = "PAESFF";

        /// <summary>
        /// PAMPJU.
        /// </summary>
        public const string PAMPJU = "PAMPJU";

        /// <summary>
        /// PAIPJF.
        /// </summary>
        public const string PAIPJF = "PAIPJF";

        /// <summary>
        /// PAJBIF.
        /// </summary>
        public const string PAJBIF = "PAJBIF";

        /// <summary>
        /// PAGLCM.
        /// </summary>
        public const string PAGLCM = "PAGLCM";

        /// <summary>
        /// PALJOB.
        /// </summary>
        public const string PALJOB = "PALJOB";

        /// <summary>
        /// PAMCUS.
        /// </summary>
        public const string PAMCUS = "PAMCUS";

        /// <summary>
        /// PACAQA.
        /// </summary>
        public const string PACAQA = "PACAQA";

        /// <summary>
        /// PAPBMT.
        /// </summary>
        public const string PAPBMT = "PAPBMT";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAPID.
        /// </summary>
        public const string PAPID = "PAPID";

        /// <summary>
        /// PAJOBN.
        /// </summary>
        public const string PAJOBN = "PAJOBN";

        /// <summary>
        /// PAUPMT.
        /// </summary>
        public const string PAUPMT = "PAUPMT";

        /// <summary>
        /// PAUPMJ.
        /// </summary>
        public const string PAUPMJ = "PAUPMJ";

        /// <summary>
        /// PAOSTP.
        /// </summary>
        public const string PAOSTP = "PAOSTP";

        /// <summary>
        /// PAPA8.
        /// </summary>
        public const string PAPA8 = "PAPA8";

        /// <summary>
        /// PARSIF.
        /// </summary>
        public const string PARSIF = "PARSIF";

        /// <summary>
        /// PACLLX.
        /// </summary>
        public const string PACLLX = "PACLLX";

        /// <summary>
        /// PAALRTFG.
        /// </summary>
        public const string PAALRTFG = "PAALRTFG";

        /// <summary>
        /// PARORN.
        /// </summary>
        public const string PARORN = "PARORN";
    }

    /// <inheritdoc />
    public override string TableName => "F31P01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PAPRJM", "PAPRJM", JdeDataType.Numeric, null, true, true),
        new JdeField("PAOVEF", "PAOVEF", JdeDataType.String, 2),
        new JdeField("PAJCBU", "PAJCBU", JdeDataType.String, 2),
        new JdeField("PAREAF", "PAREAF", JdeDataType.String, 2),
        new JdeField("PALWBS", "PALWBS", JdeDataType.String, 2),
        new JdeField("PADOCO", "PADOCO", JdeDataType.Numeric),
        new JdeField("PADCTO", "PADCTO", JdeDataType.String, 4),
        new JdeField("PAKCOO", "PAKCOO", JdeDataType.String, 10),
        new JdeField("PAQTAF", "PAQTAF", JdeDataType.String, 2),
        new JdeField("PAESFF", "PAESFF", JdeDataType.String, 2),
        new JdeField("PAMPJU", "PAMPJU", JdeDataType.String, 2),
        new JdeField("PAIPJF", "PAIPJF", JdeDataType.String, 2),
        new JdeField("PAJBIF", "PAJBIF", JdeDataType.String, 2),
        new JdeField("PAGLCM", "PAGLCM", JdeDataType.String, 8),
        new JdeField("PALJOB", "PALJOB", JdeDataType.String, 2),
        new JdeField("PAMCUS", "PAMCUS", JdeDataType.String, 24),
        new JdeField("PACAQA", "PACAQA", JdeDataType.String, 2),
        new JdeField("PAPBMT", "PAPBMT", JdeDataType.String, 2),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PAJOBN", "PAJOBN", JdeDataType.String, 20),
        new JdeField("PAUPMT", "PAUPMT", JdeDataType.Numeric),
        new JdeField("PAUPMJ", "PAUPMJ", JdeDataType.Numeric),
        new JdeField("PAOSTP", "PAOSTP", JdeDataType.String, 6),
        new JdeField("PAPA8", "PAPA8", JdeDataType.Numeric),
        new JdeField("PARSIF", "PARSIF", JdeDataType.String, 2),
        new JdeField("PACLLX", "PACLLX", JdeDataType.String, 2),
        new JdeField("PAALRTFG", "PAALRTFG", JdeDataType.String, 2),
        new JdeField("PARORN", "PARORN", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31P01_0", "Primary Key on PAPRJM", new[] { "PAPRJM" }, isUnique: true, isPrimaryKey: true)
    };
}
