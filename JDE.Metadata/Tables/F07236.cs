using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07236 - .
/// </summary>
public class F07236 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y6HMCO.
        /// </summary>
        public const string Y6HMCO = "Y6HMCO";

        /// <summary>
        /// Y6HMCU.
        /// </summary>
        public const string Y6HMCU = "Y6HMCU";

        /// <summary>
        /// Y6ADBN.
        /// </summary>
        public const string Y6ADBN = "Y6ADBN";

        /// <summary>
        /// Y6BTRN.
        /// </summary>
        public const string Y6BTRN = "Y6BTRN";

        /// <summary>
        /// Y6BKAN.
        /// </summary>
        public const string Y6BKAN = "Y6BKAN";

        /// <summary>
        /// Y6IDEN.
        /// </summary>
        public const string Y6IDEN = "Y6IDEN";

        /// <summary>
        /// Y6CNM.
        /// </summary>
        public const string Y6CNM = "Y6CNM";

        /// <summary>
        /// Y6SCC.
        /// </summary>
        public const string Y6SCC = "Y6SCC";

        /// <summary>
        /// Y6DDTA.
        /// </summary>
        public const string Y6DDTA = "Y6DDTA";

        /// <summary>
        /// Y6IMDS.
        /// </summary>
        public const string Y6IMDS = "Y6IMDS";

        /// <summary>
        /// Y6IMOR.
        /// </summary>
        public const string Y6IMOR = "Y6IMOR";

        /// <summary>
        /// Y6FIDM.
        /// </summary>
        public const string Y6FIDM = "Y6FIDM";

        /// <summary>
        /// Y6ADHR.
        /// </summary>
        public const string Y6ADHR = "Y6ADHR";

        /// <summary>
        /// Y6ADTL.
        /// </summary>
        public const string Y6ADTL = "Y6ADTL";
    }

    /// <inheritdoc />
    public override string TableName => "F07236";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y6HMCO", "Y6HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y6HMCU", "Y6HMCU", JdeDataType.String, 24, true, true),
        new JdeField("Y6ADBN", "Y6ADBN", JdeDataType.Numeric),
        new JdeField("Y6BTRN", "Y6BTRN", JdeDataType.String, 40),
        new JdeField("Y6BKAN", "Y6BKAN", JdeDataType.String, 40),
        new JdeField("Y6IDEN", "Y6IDEN", JdeDataType.String, 20),
        new JdeField("Y6CNM", "Y6CNM", JdeDataType.String, 46),
        new JdeField("Y6SCC", "Y6SCC", JdeDataType.String, 6),
        new JdeField("Y6DDTA", "Y6DDTA", JdeDataType.String, 40),
        new JdeField("Y6IMDS", "Y6IMDS", JdeDataType.String, 20),
        new JdeField("Y6IMOR", "Y6IMOR", JdeDataType.String, 20),
        new JdeField("Y6FIDM", "Y6FIDM", JdeDataType.String, 2),
        new JdeField("Y6ADHR", "Y6ADHR", JdeDataType.String, 180),
        new JdeField("Y6ADTL", "Y6ADTL", JdeDataType.String, 180)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07236_0", "Primary Key on Y6HMCO, Y6HMCU", new[] { "Y6HMCO", "Y6HMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
