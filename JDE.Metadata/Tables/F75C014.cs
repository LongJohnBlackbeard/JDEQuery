using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C014 - .
/// </summary>
public class F75C014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BACO.
        /// </summary>
        public const string BACO = "BACO";

        /// <summary>
        /// BAC75NAC.
        /// </summary>
        public const string BAC75NAC = "BAC75NAC";

        /// <summary>
        /// BAAN8.
        /// </summary>
        public const string BAAN8 = "BAAN8";

        /// <summary>
        /// BACTRY.
        /// </summary>
        public const string BACTRY = "BACTRY";

        /// <summary>
        /// BAFY.
        /// </summary>
        public const string BAFY = "BAFY";

        /// <summary>
        /// BAC75MODE.
        /// </summary>
        public const string BAC75MODE = "BAC75MODE";

        /// <summary>
        /// BAAPYC.
        /// </summary>
        public const string BAAPYC = "BAAPYC";

        /// <summary>
        /// BABCRC.
        /// </summary>
        public const string BABCRC = "BABCRC";

        /// <summary>
        /// BAAA.
        /// </summary>
        public const string BAAA = "BAAA";

        /// <summary>
        /// BAACR.
        /// </summary>
        public const string BAACR = "BAACR";

        /// <summary>
        /// BACRCD.
        /// </summary>
        public const string BACRCD = "BACRCD";

        /// <summary>
        /// BAC75TRTP.
        /// </summary>
        public const string BAC75TRTP = "BAC75TRTP";

        /// <summary>
        /// BAFUTSTR1.
        /// </summary>
        public const string BAFUTSTR1 = "BAFUTSTR1";

        /// <summary>
        /// BAFUTMATH1.
        /// </summary>
        public const string BAFUTMATH1 = "BAFUTMATH1";

        /// <summary>
        /// BAFUTDATE1.
        /// </summary>
        public const string BAFUTDATE1 = "BAFUTDATE1";

        /// <summary>
        /// BAFUTUO1.
        /// </summary>
        public const string BAFUTUO1 = "BAFUTUO1";

        /// <summary>
        /// BAUSER.
        /// </summary>
        public const string BAUSER = "BAUSER";

        /// <summary>
        /// BAPID.
        /// </summary>
        public const string BAPID = "BAPID";

        /// <summary>
        /// BAJOBN.
        /// </summary>
        public const string BAJOBN = "BAJOBN";

        /// <summary>
        /// BAUPMJ.
        /// </summary>
        public const string BAUPMJ = "BAUPMJ";

        /// <summary>
        /// BAUPMT.
        /// </summary>
        public const string BAUPMT = "BAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BACO", "BACO", JdeDataType.String, 10, true, true),
        new JdeField("BAC75NAC", "BAC75NAC", JdeDataType.String, 60, true, true),
        new JdeField("BAAN8", "BAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BACTRY", "BACTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("BAFY", "BAFY", JdeDataType.Numeric, null, true, true),
        new JdeField("BAC75MODE", "BAC75MODE", JdeDataType.String, 2, true, true),
        new JdeField("BAAPYC", "BAAPYC", JdeDataType.Numeric),
        new JdeField("BABCRC", "BABCRC", JdeDataType.String, 6),
        new JdeField("BAAA", "BAAA", JdeDataType.Numeric),
        new JdeField("BAACR", "BAACR", JdeDataType.Numeric),
        new JdeField("BACRCD", "BACRCD", JdeDataType.String, 6),
        new JdeField("BAC75TRTP", "BAC75TRTP", JdeDataType.String, 2),
        new JdeField("BAFUTSTR1", "BAFUTSTR1", JdeDataType.String, 100),
        new JdeField("BAFUTMATH1", "BAFUTMATH1", JdeDataType.Numeric),
        new JdeField("BAFUTDATE1", "BAFUTDATE1", JdeDataType.Numeric),
        new JdeField("BAFUTUO1", "BAFUTUO1", JdeDataType.String, 2),
        new JdeField("BAUSER", "BAUSER", JdeDataType.String, 20),
        new JdeField("BAPID", "BAPID", JdeDataType.String, 20),
        new JdeField("BAJOBN", "BAJOBN", JdeDataType.String, 20),
        new JdeField("BAUPMJ", "BAUPMJ", JdeDataType.Numeric),
        new JdeField("BAUPMT", "BAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C014_0", "Primary Key on BACO, BAAN8, BAC75NAC, BACTRY, BAFY, BAC75MODE", new[] { "BACO", "BAAN8", "BAC75NAC", "BACTRY", "BAFY", "BAC75MODE" }, isUnique: true, isPrimaryKey: true)
    };
}
