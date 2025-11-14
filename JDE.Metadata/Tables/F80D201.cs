using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D201 - .
/// </summary>
public class F80D201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PAPRDJ.
        /// </summary>
        public const string PAPRDJ = "PAPRDJ";

        /// <summary>
        /// PAMCU.
        /// </summary>
        public const string PAMCU = "PAMCU";

        /// <summary>
        /// PAITM.
        /// </summary>
        public const string PAITM = "PAITM";

        /// <summary>
        /// PACOGS.
        /// </summary>
        public const string PACOGS = "PACOGS";

        /// <summary>
        /// PAPDPO.
        /// </summary>
        public const string PAPDPO = "PAPDPO";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAPID.
        /// </summary>
        public const string PAPID = "PAPID";

        /// <summary>
        /// PAMKEY.
        /// </summary>
        public const string PAMKEY = "PAMKEY";

        /// <summary>
        /// PAUTIME.
        /// </summary>
        public const string PAUTIME = "PAUTIME";

        /// <summary>
        /// PAURCD.
        /// </summary>
        public const string PAURCD = "PAURCD";

        /// <summary>
        /// PAURDT.
        /// </summary>
        public const string PAURDT = "PAURDT";

        /// <summary>
        /// PAURAT.
        /// </summary>
        public const string PAURAT = "PAURAT";

        /// <summary>
        /// PAURAB.
        /// </summary>
        public const string PAURAB = "PAURAB";

        /// <summary>
        /// PAURRF.
        /// </summary>
        public const string PAURRF = "PAURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PAPRDJ", "PAPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PAMCU", "PAMCU", JdeDataType.String, 24, true, true),
        new JdeField("PAITM", "PAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PACOGS", "PACOGS", JdeDataType.Numeric),
        new JdeField("PAPDPO", "PAPDPO", JdeDataType.Numeric),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PAMKEY", "PAMKEY", JdeDataType.String, 30),
        new JdeField("PAUTIME", "PAUTIME", JdeDataType.Date),
        new JdeField("PAURCD", "PAURCD", JdeDataType.String, 4),
        new JdeField("PAURDT", "PAURDT", JdeDataType.Numeric),
        new JdeField("PAURAT", "PAURAT", JdeDataType.Numeric),
        new JdeField("PAURAB", "PAURAB", JdeDataType.Numeric),
        new JdeField("PAURRF", "PAURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D201_0", "Primary Key on PAPRDJ, PAMCU, PAITM", new[] { "PAPRDJ", "PAMCU", "PAITM" }, isUnique: true, isPrimaryKey: true)
    };
}
