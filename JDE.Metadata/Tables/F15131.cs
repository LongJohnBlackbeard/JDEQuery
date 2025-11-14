using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15131 - .
/// </summary>
public class F15131 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LFDOCO.
        /// </summary>
        public const string LFDOCO = "LFDOCO";

        /// <summary>
        /// LFLAFLTD.
        /// </summary>
        public const string LFLAFLTD = "LFLAFLTD";

        /// <summary>
        /// LFLALVS.
        /// </summary>
        public const string LFLALVS = "LFLALVS";

        /// <summary>
        /// LFLALVED.
        /// </summary>
        public const string LFLALVED = "LFLALVED";

        /// <summary>
        /// LFLAFTBD.
        /// </summary>
        public const string LFLAFTBD = "LFLAFTBD";

        /// <summary>
        /// LFLAFTED.
        /// </summary>
        public const string LFLAFTED = "LFLAFTED";

        /// <summary>
        /// LFLABEOA.
        /// </summary>
        public const string LFLABEOA = "LFLABEOA";

        /// <summary>
        /// LFURCD.
        /// </summary>
        public const string LFURCD = "LFURCD";

        /// <summary>
        /// LFURRF.
        /// </summary>
        public const string LFURRF = "LFURRF";

        /// <summary>
        /// LFURAT.
        /// </summary>
        public const string LFURAT = "LFURAT";

        /// <summary>
        /// LFURDT.
        /// </summary>
        public const string LFURDT = "LFURDT";

        /// <summary>
        /// LFURAB.
        /// </summary>
        public const string LFURAB = "LFURAB";

        /// <summary>
        /// LFTORG.
        /// </summary>
        public const string LFTORG = "LFTORG";

        /// <summary>
        /// LFENTJ.
        /// </summary>
        public const string LFENTJ = "LFENTJ";

        /// <summary>
        /// LFUSER.
        /// </summary>
        public const string LFUSER = "LFUSER";

        /// <summary>
        /// LFMKEY.
        /// </summary>
        public const string LFMKEY = "LFMKEY";

        /// <summary>
        /// LFUPMJ.
        /// </summary>
        public const string LFUPMJ = "LFUPMJ";

        /// <summary>
        /// LFUPMT.
        /// </summary>
        public const string LFUPMT = "LFUPMT";

        /// <summary>
        /// LFPID.
        /// </summary>
        public const string LFPID = "LFPID";
    }

    /// <inheritdoc />
    public override string TableName => "F15131";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LFDOCO", "LFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LFLAFLTD", "LFLAFLTD", JdeDataType.String, 2),
        new JdeField("LFLALVS", "LFLALVS", JdeDataType.String, 2),
        new JdeField("LFLALVED", "LFLALVED", JdeDataType.Numeric),
        new JdeField("LFLAFTBD", "LFLAFTBD", JdeDataType.Numeric),
        new JdeField("LFLAFTED", "LFLAFTED", JdeDataType.Numeric),
        new JdeField("LFLABEOA", "LFLABEOA", JdeDataType.String, 2),
        new JdeField("LFURCD", "LFURCD", JdeDataType.String, 4),
        new JdeField("LFURRF", "LFURRF", JdeDataType.String, 30),
        new JdeField("LFURAT", "LFURAT", JdeDataType.Numeric),
        new JdeField("LFURDT", "LFURDT", JdeDataType.Numeric),
        new JdeField("LFURAB", "LFURAB", JdeDataType.Numeric),
        new JdeField("LFTORG", "LFTORG", JdeDataType.String, 20),
        new JdeField("LFENTJ", "LFENTJ", JdeDataType.Numeric),
        new JdeField("LFUSER", "LFUSER", JdeDataType.String, 20),
        new JdeField("LFMKEY", "LFMKEY", JdeDataType.String, 30),
        new JdeField("LFUPMJ", "LFUPMJ", JdeDataType.Numeric),
        new JdeField("LFUPMT", "LFUPMT", JdeDataType.Numeric),
        new JdeField("LFPID", "LFPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15131_0", "Primary Key on LFDOCO", new[] { "LFDOCO" }, isUnique: true, isPrimaryKey: true)
    };
}
