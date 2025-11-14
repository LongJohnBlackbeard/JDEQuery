using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I323 - .
/// </summary>
public class F75I323 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RAMATC.
        /// </summary>
        public const string RAMATC = "RAMATC";

        /// <summary>
        /// RAKCOO.
        /// </summary>
        public const string RAKCOO = "RAKCOO";

        /// <summary>
        /// RADOCO.
        /// </summary>
        public const string RADOCO = "RADOCO";

        /// <summary>
        /// RADCTO.
        /// </summary>
        public const string RADCTO = "RADCTO";

        /// <summary>
        /// RASFXO.
        /// </summary>
        public const string RASFXO = "RASFXO";

        /// <summary>
        /// RALNID.
        /// </summary>
        public const string RALNID = "RALNID";

        /// <summary>
        /// RANLIN.
        /// </summary>
        public const string RANLIN = "RANLIN";

        /// <summary>
        /// RADOC.
        /// </summary>
        public const string RADOC = "RADOC";

        /// <summary>
        /// RAYAR3N.
        /// </summary>
        public const string RAYAR3N = "RAYAR3N";

        /// <summary>
        /// RAI75ARDT.
        /// </summary>
        public const string RAI75ARDT = "RAI75ARDT";

        /// <summary>
        /// RAI75ENDT.
        /// </summary>
        public const string RAI75ENDT = "RAI75ENDT";

        /// <summary>
        /// RAI75ACTK.
        /// </summary>
        public const string RAI75ACTK = "RAI75ACTK";

        /// <summary>
        /// RAI75REMK.
        /// </summary>
        public const string RAI75REMK = "RAI75REMK";

        /// <summary>
        /// RAUSER.
        /// </summary>
        public const string RAUSER = "RAUSER";

        /// <summary>
        /// RAPID.
        /// </summary>
        public const string RAPID = "RAPID";

        /// <summary>
        /// RAJOBN.
        /// </summary>
        public const string RAJOBN = "RAJOBN";

        /// <summary>
        /// RAUPMJ.
        /// </summary>
        public const string RAUPMJ = "RAUPMJ";

        /// <summary>
        /// RAUPMT.
        /// </summary>
        public const string RAUPMT = "RAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I323";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RAMATC", "RAMATC", JdeDataType.String, 2, true, true),
        new JdeField("RAKCOO", "RAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RADOCO", "RADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RADCTO", "RADCTO", JdeDataType.String, 4, true, true),
        new JdeField("RASFXO", "RASFXO", JdeDataType.String, 6, true, true),
        new JdeField("RALNID", "RALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RANLIN", "RANLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("RADOC", "RADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RAYAR3N", "RAYAR3N", JdeDataType.Numeric),
        new JdeField("RAI75ARDT", "RAI75ARDT", JdeDataType.Numeric),
        new JdeField("RAI75ENDT", "RAI75ENDT", JdeDataType.Numeric),
        new JdeField("RAI75ACTK", "RAI75ACTK", JdeDataType.String, 40),
        new JdeField("RAI75REMK", "RAI75REMK", JdeDataType.String, 60),
        new JdeField("RAUSER", "RAUSER", JdeDataType.String, 20),
        new JdeField("RAPID", "RAPID", JdeDataType.String, 20),
        new JdeField("RAJOBN", "RAJOBN", JdeDataType.String, 20),
        new JdeField("RAUPMJ", "RAUPMJ", JdeDataType.Numeric),
        new JdeField("RAUPMT", "RAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I323_0", "Primary Key on RAMATC, RAKCOO, RADOCO, RADCTO, RASFXO, RALNID, RANLIN, RADOC", new[] { "RAMATC", "RAKCOO", "RADOCO", "RADCTO", "RASFXO", "RALNID", "RANLIN", "RADOC" }, isUnique: true, isPrimaryKey: true)
    };
}
