using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74CUI01 - .
/// </summary>
public class F74CUI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESESRN.
        /// </summary>
        public const string ESESRN = "ESESRN";

        /// <summary>
        /// ESCKAM.
        /// </summary>
        public const string ESCKAM = "ESCKAM";

        /// <summary>
        /// ESCRCD.
        /// </summary>
        public const string ESCRCD = "ESCRCD";

        /// <summary>
        /// ESBKDTE.
        /// </summary>
        public const string ESBKDTE = "ESBKDTE";

        /// <summary>
        /// ESVALDTE.
        /// </summary>
        public const string ESVALDTE = "ESVALDTE";

        /// <summary>
        /// ESJOBS.
        /// </summary>
        public const string ESJOBS = "ESJOBS";

        /// <summary>
        /// ESUSER.
        /// </summary>
        public const string ESUSER = "ESUSER";

        /// <summary>
        /// ESPID.
        /// </summary>
        public const string ESPID = "ESPID";

        /// <summary>
        /// ESJOBN.
        /// </summary>
        public const string ESJOBN = "ESJOBN";

        /// <summary>
        /// ESUPMJ.
        /// </summary>
        public const string ESUPMJ = "ESUPMJ";

        /// <summary>
        /// ESUPMT.
        /// </summary>
        public const string ESUPMT = "ESUPMT";

        /// <summary>
        /// ESC74FUT01.
        /// </summary>
        public const string ESC74FUT01 = "ESC74FUT01";

        /// <summary>
        /// ESC74FUT02.
        /// </summary>
        public const string ESC74FUT02 = "ESC74FUT02";

        /// <summary>
        /// ESC74FUT03.
        /// </summary>
        public const string ESC74FUT03 = "ESC74FUT03";

        /// <summary>
        /// ESC74FUT04.
        /// </summary>
        public const string ESC74FUT04 = "ESC74FUT04";

        /// <summary>
        /// ESC74FUT05.
        /// </summary>
        public const string ESC74FUT05 = "ESC74FUT05";
    }

    /// <inheritdoc />
    public override string TableName => "F74CUI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESESRN", "ESESRN", JdeDataType.String, 54, true, true),
        new JdeField("ESCKAM", "ESCKAM", JdeDataType.Numeric),
        new JdeField("ESCRCD", "ESCRCD", JdeDataType.String, 6),
        new JdeField("ESBKDTE", "ESBKDTE", JdeDataType.Numeric),
        new JdeField("ESVALDTE", "ESVALDTE", JdeDataType.Numeric),
        new JdeField("ESJOBS", "ESJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20, true, true),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESJOBN", "ESJOBN", JdeDataType.String, 20),
        new JdeField("ESUPMJ", "ESUPMJ", JdeDataType.Numeric),
        new JdeField("ESUPMT", "ESUPMT", JdeDataType.Numeric),
        new JdeField("ESC74FUT01", "ESC74FUT01", JdeDataType.Numeric),
        new JdeField("ESC74FUT02", "ESC74FUT02", JdeDataType.String, 60),
        new JdeField("ESC74FUT03", "ESC74FUT03", JdeDataType.String, 2),
        new JdeField("ESC74FUT04", "ESC74FUT04", JdeDataType.String, 2),
        new JdeField("ESC74FUT05", "ESC74FUT05", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74CUI01_0", "Primary Key on ESESRN, ESJOBS, ESUSER", new[] { "ESESRN", "ESJOBS", "ESUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
