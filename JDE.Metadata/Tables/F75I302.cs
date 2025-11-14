using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I302 - .
/// </summary>
public class F75I302 : JdeTable
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
        /// QAYPDS.
        /// </summary>
        public const string QAYPDS = "QAYPDS";

        /// <summary>
        /// QAYPDE.
        /// </summary>
        public const string QAYPDE = "QAYPDE";

        /// <summary>
        /// QAYCDS.
        /// </summary>
        public const string QAYCDS = "QAYCDS";

        /// <summary>
        /// QAYCDE.
        /// </summary>
        public const string QAYCDE = "QAYCDE";

        /// <summary>
        /// QALCD1.
        /// </summary>
        public const string QALCD1 = "QALCD1";

        /// <summary>
        /// QALCD2.
        /// </summary>
        public const string QALCD2 = "QALCD2";

        /// <summary>
        /// QALCD3.
        /// </summary>
        public const string QALCD3 = "QALCD3";

        /// <summary>
        /// QALCD4.
        /// </summary>
        public const string QALCD4 = "QALCD4";

        /// <summary>
        /// QAMCU.
        /// </summary>
        public const string QAMCU = "QAMCU";

        /// <summary>
        /// QAOBJ.
        /// </summary>
        public const string QAOBJ = "QAOBJ";

        /// <summary>
        /// QASUB.
        /// </summary>
        public const string QASUB = "QASUB";

        /// <summary>
        /// QAMCU0.
        /// </summary>
        public const string QAMCU0 = "QAMCU0";

        /// <summary>
        /// QAOBJ0.
        /// </summary>
        public const string QAOBJ0 = "QAOBJ0";

        /// <summary>
        /// QASUB0.
        /// </summary>
        public const string QASUB0 = "QASUB0";

        /// <summary>
        /// QAMCU1.
        /// </summary>
        public const string QAMCU1 = "QAMCU1";

        /// <summary>
        /// QAOBJ1.
        /// </summary>
        public const string QAOBJ1 = "QAOBJ1";

        /// <summary>
        /// QASUB1.
        /// </summary>
        public const string QASUB1 = "QASUB1";

        /// <summary>
        /// QAMCU2.
        /// </summary>
        public const string QAMCU2 = "QAMCU2";

        /// <summary>
        /// QAOBJ2.
        /// </summary>
        public const string QAOBJ2 = "QAOBJ2";

        /// <summary>
        /// QASUB2.
        /// </summary>
        public const string QASUB2 = "QASUB2";

        /// <summary>
        /// QAMCU4.
        /// </summary>
        public const string QAMCU4 = "QAMCU4";

        /// <summary>
        /// QAOBJ4.
        /// </summary>
        public const string QAOBJ4 = "QAOBJ4";

        /// <summary>
        /// QASUB4.
        /// </summary>
        public const string QASUB4 = "QASUB4";

        /// <summary>
        /// QAMCU5.
        /// </summary>
        public const string QAMCU5 = "QAMCU5";

        /// <summary>
        /// QAOBJ5.
        /// </summary>
        public const string QAOBJ5 = "QAOBJ5";

        /// <summary>
        /// QASUB5.
        /// </summary>
        public const string QASUB5 = "QASUB5";

        /// <summary>
        /// QAMCU6.
        /// </summary>
        public const string QAMCU6 = "QAMCU6";

        /// <summary>
        /// QAOBJ6.
        /// </summary>
        public const string QAOBJ6 = "QAOBJ6";

        /// <summary>
        /// QASUB6.
        /// </summary>
        public const string QASUB6 = "QASUB6";

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
        /// QATDAY.
        /// </summary>
        public const string QATDAY = "QATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAYEXU", "QAYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("QAYPDS", "QAYPDS", JdeDataType.Numeric),
        new JdeField("QAYPDE", "QAYPDE", JdeDataType.Numeric),
        new JdeField("QAYCDS", "QAYCDS", JdeDataType.Numeric),
        new JdeField("QAYCDE", "QAYCDE", JdeDataType.Numeric),
        new JdeField("QALCD1", "QALCD1", JdeDataType.Numeric),
        new JdeField("QALCD2", "QALCD2", JdeDataType.Numeric),
        new JdeField("QALCD3", "QALCD3", JdeDataType.Numeric),
        new JdeField("QALCD4", "QALCD4", JdeDataType.Numeric),
        new JdeField("QAMCU", "QAMCU", JdeDataType.String, 24),
        new JdeField("QAOBJ", "QAOBJ", JdeDataType.String, 12),
        new JdeField("QASUB", "QASUB", JdeDataType.String, 16),
        new JdeField("QAMCU0", "QAMCU0", JdeDataType.String, 24),
        new JdeField("QAOBJ0", "QAOBJ0", JdeDataType.String, 12),
        new JdeField("QASUB0", "QASUB0", JdeDataType.String, 16),
        new JdeField("QAMCU1", "QAMCU1", JdeDataType.String, 24),
        new JdeField("QAOBJ1", "QAOBJ1", JdeDataType.String, 12),
        new JdeField("QASUB1", "QASUB1", JdeDataType.String, 16),
        new JdeField("QAMCU2", "QAMCU2", JdeDataType.String, 24),
        new JdeField("QAOBJ2", "QAOBJ2", JdeDataType.String, 12),
        new JdeField("QASUB2", "QASUB2", JdeDataType.String, 16),
        new JdeField("QAMCU4", "QAMCU4", JdeDataType.String, 24),
        new JdeField("QAOBJ4", "QAOBJ4", JdeDataType.String, 12),
        new JdeField("QASUB4", "QASUB4", JdeDataType.String, 16),
        new JdeField("QAMCU5", "QAMCU5", JdeDataType.String, 24),
        new JdeField("QAOBJ5", "QAOBJ5", JdeDataType.String, 12),
        new JdeField("QASUB5", "QASUB5", JdeDataType.String, 16),
        new JdeField("QAMCU6", "QAMCU6", JdeDataType.String, 24),
        new JdeField("QAOBJ6", "QAOBJ6", JdeDataType.String, 12),
        new JdeField("QASUB6", "QASUB6", JdeDataType.String, 16),
        new JdeField("QAUSER", "QAUSER", JdeDataType.String, 20),
        new JdeField("QAPID", "QAPID", JdeDataType.String, 20),
        new JdeField("QAJOBN", "QAJOBN", JdeDataType.String, 20),
        new JdeField("QAUPMJ", "QAUPMJ", JdeDataType.Numeric),
        new JdeField("QATDAY", "QATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I302_0", "Primary Key on QAYEXU", new[] { "QAYEXU" }, isUnique: true, isPrimaryKey: true)
    };
}
