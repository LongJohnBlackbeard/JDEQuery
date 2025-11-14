using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I4213 - .
/// </summary>
public class F75I4213 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SOMCU.
        /// </summary>
        public const string SOMCU = "SOMCU";

        /// <summary>
        /// SOLITM.
        /// </summary>
        public const string SOLITM = "SOLITM";

        /// <summary>
        /// SOLOCN.
        /// </summary>
        public const string SOLOCN = "SOLOCN";

        /// <summary>
        /// SOLOTN.
        /// </summary>
        public const string SOLOTN = "SOLOTN";

        /// <summary>
        /// SOLINENBR.
        /// </summary>
        public const string SOLINENBR = "SOLINENBR";

        /// <summary>
        /// SOUSER.
        /// </summary>
        public const string SOUSER = "SOUSER";

        /// <summary>
        /// SOJOBN.
        /// </summary>
        public const string SOJOBN = "SOJOBN";

        /// <summary>
        /// SODOCO.
        /// </summary>
        public const string SODOCO = "SODOCO";

        /// <summary>
        /// SODOC.
        /// </summary>
        public const string SODOC = "SODOC";

        /// <summary>
        /// SODGL.
        /// </summary>
        public const string SODGL = "SODGL";

        /// <summary>
        /// SOAN8.
        /// </summary>
        public const string SOAN8 = "SOAN8";

        /// <summary>
        /// SODCT.
        /// </summary>
        public const string SODCT = "SODCT";

        /// <summary>
        /// SOTRDJ.
        /// </summary>
        public const string SOTRDJ = "SOTRDJ";

        /// <summary>
        /// SOUREC.
        /// </summary>
        public const string SOUREC = "SOUREC";

        /// <summary>
        /// SOPRRC.
        /// </summary>
        public const string SOPRRC = "SOPRRC";

        /// <summary>
        /// SOPCST.
        /// </summary>
        public const string SOPCST = "SOPCST";

        /// <summary>
        /// SOPRRCE1.
        /// </summary>
        public const string SOPRRCE1 = "SOPRRCE1";

        /// <summary>
        /// SOAREC.
        /// </summary>
        public const string SOAREC = "SOAREC";

        /// <summary>
        /// SOBIIT.
        /// </summary>
        public const string SOBIIT = "SOBIIT";

        /// <summary>
        /// SOIVD.
        /// </summary>
        public const string SOIVD = "SOIVD";

        /// <summary>
        /// SODOC2.
        /// </summary>
        public const string SODOC2 = "SODOC2";

        /// <summary>
        /// SODOC1.
        /// </summary>
        public const string SODOC1 = "SODOC1";

        /// <summary>
        /// SODCTO.
        /// </summary>
        public const string SODCTO = "SODCTO";

        /// <summary>
        /// SOAN81.
        /// </summary>
        public const string SOAN81 = "SOAN81";

        /// <summary>
        /// SOSOQS.
        /// </summary>
        public const string SOSOQS = "SOSOQS";

        /// <summary>
        /// SOUPRC.
        /// </summary>
        public const string SOUPRC = "SOUPRC";

        /// <summary>
        /// SOFVTR.
        /// </summary>
        public const string SOFVTR = "SOFVTR";

        /// <summary>
        /// SOAITA.
        /// </summary>
        public const string SOAITA = "SOAITA";

        /// <summary>
        /// SOEF01.
        /// </summary>
        public const string SOEF01 = "SOEF01";

        /// <summary>
        /// SOUPMJ.
        /// </summary>
        public const string SOUPMJ = "SOUPMJ";

        /// <summary>
        /// SOUPMT.
        /// </summary>
        public const string SOUPMT = "SOUPMT";

        /// <summary>
        /// SOI75PEEN.
        /// </summary>
        public const string SOI75PEEN = "SOI75PEEN";
    }

    /// <inheritdoc />
    public override string TableName => "F75I4213";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SOMCU", "SOMCU", JdeDataType.String, 24, true, true),
        new JdeField("SOLITM", "SOLITM", JdeDataType.String, 50, true, true),
        new JdeField("SOLOCN", "SOLOCN", JdeDataType.String, 40, true, true),
        new JdeField("SOLOTN", "SOLOTN", JdeDataType.String, 60, true, true),
        new JdeField("SOLINENBR", "SOLINENBR", JdeDataType.Numeric, null, true, true),
        new JdeField("SOUSER", "SOUSER", JdeDataType.String, 20, true, true),
        new JdeField("SOJOBN", "SOJOBN", JdeDataType.String, 20, true, true),
        new JdeField("SODOCO", "SODOCO", JdeDataType.Numeric),
        new JdeField("SODOC", "SODOC", JdeDataType.Numeric),
        new JdeField("SODGL", "SODGL", JdeDataType.Numeric),
        new JdeField("SOAN8", "SOAN8", JdeDataType.Numeric),
        new JdeField("SODCT", "SODCT", JdeDataType.String, 4),
        new JdeField("SOTRDJ", "SOTRDJ", JdeDataType.Numeric),
        new JdeField("SOUREC", "SOUREC", JdeDataType.Numeric),
        new JdeField("SOPRRC", "SOPRRC", JdeDataType.Numeric),
        new JdeField("SOPCST", "SOPCST", JdeDataType.Numeric),
        new JdeField("SOPRRCE1", "SOPRRCE1", JdeDataType.Numeric),
        new JdeField("SOAREC", "SOAREC", JdeDataType.Numeric),
        new JdeField("SOBIIT", "SOBIIT", JdeDataType.Numeric),
        new JdeField("SOIVD", "SOIVD", JdeDataType.Numeric),
        new JdeField("SODOC2", "SODOC2", JdeDataType.Numeric),
        new JdeField("SODOC1", "SODOC1", JdeDataType.Numeric),
        new JdeField("SODCTO", "SODCTO", JdeDataType.String, 4),
        new JdeField("SOAN81", "SOAN81", JdeDataType.Numeric),
        new JdeField("SOSOQS", "SOSOQS", JdeDataType.Numeric),
        new JdeField("SOUPRC", "SOUPRC", JdeDataType.Numeric),
        new JdeField("SOFVTR", "SOFVTR", JdeDataType.Numeric),
        new JdeField("SOAITA", "SOAITA", JdeDataType.Numeric),
        new JdeField("SOEF01", "SOEF01", JdeDataType.Numeric),
        new JdeField("SOUPMJ", "SOUPMJ", JdeDataType.Numeric),
        new JdeField("SOUPMT", "SOUPMT", JdeDataType.Numeric),
        new JdeField("SOI75PEEN", "SOI75PEEN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I4213_0", "Primary Key on SOMCU, SOLITM, SOLOCN, SOLOTN, SOLINENBR, SOUSER, SOJOBN", new[] { "SOMCU", "SOLITM", "SOLOCN", "SOLOTN", "SOLINENBR", "SOUSER", "SOJOBN" }, isUnique: true, isPrimaryKey: true)
    };
}
