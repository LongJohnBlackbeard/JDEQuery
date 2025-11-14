using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P506 - .
/// </summary>
public class F74P506 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FAKCO.
        /// </summary>
        public const string FAKCO = "FAKCO";

        /// <summary>
        /// FADOCO.
        /// </summary>
        public const string FADOCO = "FADOCO";

        /// <summary>
        /// FADCT.
        /// </summary>
        public const string FADCT = "FADCT";

        /// <summary>
        /// FASFX.
        /// </summary>
        public const string FASFX = "FASFX";

        /// <summary>
        /// FAP74FAF.
        /// </summary>
        public const string FAP74FAF = "FAP74FAF";

        /// <summary>
        /// FAP74FUT01.
        /// </summary>
        public const string FAP74FUT01 = "FAP74FUT01";

        /// <summary>
        /// FAP74FUT02.
        /// </summary>
        public const string FAP74FUT02 = "FAP74FUT02";

        /// <summary>
        /// FAP74FUT03.
        /// </summary>
        public const string FAP74FUT03 = "FAP74FUT03";

        /// <summary>
        /// FAP74FLG04.
        /// </summary>
        public const string FAP74FLG04 = "FAP74FLG04";

        /// <summary>
        /// FAP74NUM05.
        /// </summary>
        public const string FAP74NUM05 = "FAP74NUM05";

        /// <summary>
        /// FAUSER.
        /// </summary>
        public const string FAUSER = "FAUSER";

        /// <summary>
        /// FAPID.
        /// </summary>
        public const string FAPID = "FAPID";

        /// <summary>
        /// FAJOBN.
        /// </summary>
        public const string FAJOBN = "FAJOBN";

        /// <summary>
        /// FAUPMJ.
        /// </summary>
        public const string FAUPMJ = "FAUPMJ";

        /// <summary>
        /// FAUPMT.
        /// </summary>
        public const string FAUPMT = "FAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74P506";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FAKCO", "FAKCO", JdeDataType.String, 10, true, true),
        new JdeField("FADOCO", "FADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("FADCT", "FADCT", JdeDataType.String, 4, true, true),
        new JdeField("FASFX", "FASFX", JdeDataType.String, 6, true, true),
        new JdeField("FAP74FAF", "FAP74FAF", JdeDataType.String, 2),
        new JdeField("FAP74FUT01", "FAP74FUT01", JdeDataType.Numeric),
        new JdeField("FAP74FUT02", "FAP74FUT02", JdeDataType.String, 60),
        new JdeField("FAP74FUT03", "FAP74FUT03", JdeDataType.String, 2),
        new JdeField("FAP74FLG04", "FAP74FLG04", JdeDataType.String, 2),
        new JdeField("FAP74NUM05", "FAP74NUM05", JdeDataType.Numeric),
        new JdeField("FAUSER", "FAUSER", JdeDataType.String, 20),
        new JdeField("FAPID", "FAPID", JdeDataType.String, 20),
        new JdeField("FAJOBN", "FAJOBN", JdeDataType.String, 20),
        new JdeField("FAUPMJ", "FAUPMJ", JdeDataType.Numeric),
        new JdeField("FAUPMT", "FAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P506_0", "Primary Key on FAKCO, FADCT, FADOCO, FASFX", new[] { "FAKCO", "FADCT", "FADOCO", "FASFX" }, isUnique: true, isPrimaryKey: true)
    };
}
