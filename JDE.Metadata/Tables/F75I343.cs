using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I343 - .
/// </summary>
public class F75I343 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QAYEXU.
        /// </summary>
        public const string QAYEXU = "QAYEXU";

        /// <summary>
        /// QAYCDS.
        /// </summary>
        public const string QAYCDS = "QAYCDS";

        /// <summary>
        /// QAYCDE.
        /// </summary>
        public const string QAYCDE = "QAYCDE";

        /// <summary>
        /// QAMCU.
        /// </summary>
        public const string QAMCU = "QAMCU";

        /// <summary>
        /// QATKID.
        /// </summary>
        public const string QATKID = "QATKID";

        /// <summary>
        /// QAITM.
        /// </summary>
        public const string QAITM = "QAITM";

        /// <summary>
        /// QATRDJ.
        /// </summary>
        public const string QATRDJ = "QATRDJ";

        /// <summary>
        /// QATRQT.
        /// </summary>
        public const string QATRQT = "QATRQT";

        /// <summary>
        /// QATRUM.
        /// </summary>
        public const string QATRUM = "QATRUM";

        /// <summary>
        /// QAUSER.
        /// </summary>
        public const string QAUSER = "QAUSER";

        /// <summary>
        /// QAPID.
        /// </summary>
        public const string QAPID = "QAPID";

        /// <summary>
        /// QAJOBN.
        /// </summary>
        public const string QAJOBN = "QAJOBN";

        /// <summary>
        /// QAUPMJ.
        /// </summary>
        public const string QAUPMJ = "QAUPMJ";

        /// <summary>
        /// QAUPMT.
        /// </summary>
        public const string QAUPMT = "QAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I343";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAYEXU", "QAYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("QAYCDS", "QAYCDS", JdeDataType.Numeric, null, true, true),
        new JdeField("QAYCDE", "QAYCDE", JdeDataType.Numeric, null, true, true),
        new JdeField("QAMCU", "QAMCU", JdeDataType.String, 24, true, true),
        new JdeField("QATKID", "QATKID", JdeDataType.String, 16, true, true),
        new JdeField("QAITM", "QAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("QATRDJ", "QATRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("QATRQT", "QATRQT", JdeDataType.Numeric),
        new JdeField("QATRUM", "QATRUM", JdeDataType.String, 4),
        new JdeField("QAUSER", "QAUSER", JdeDataType.String, 20),
        new JdeField("QAPID", "QAPID", JdeDataType.String, 20),
        new JdeField("QAJOBN", "QAJOBN", JdeDataType.String, 20),
        new JdeField("QAUPMJ", "QAUPMJ", JdeDataType.Numeric),
        new JdeField("QAUPMT", "QAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I343_0", "Primary Key on QAYEXU, QAMCU, QATKID, QAITM, QAYCDS, QAYCDE, QATRDJ", new[] { "QAYEXU", "QAMCU", "QATKID", "QAITM", "QAYCDS", "QAYCDE", "QATRDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
