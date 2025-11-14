using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B8200 - .
/// </summary>
public class F76B8200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FANUMB.
        /// </summary>
        public const string FANUMB = "FANUMB";

        /// <summary>
        /// FANORU.
        /// </summary>
        public const string FANORU = "FANORU";

        /// <summary>
        /// FAAAID.
        /// </summary>
        public const string FAAAID = "FAAAID";

        /// <summary>
        /// FADL01.
        /// </summary>
        public const string FADL01 = "FADL01";

        /// <summary>
        /// FADL02.
        /// </summary>
        public const string FADL02 = "FADL02";

        /// <summary>
        /// FADL03.
        /// </summary>
        public const string FADL03 = "FADL03";

        /// <summary>
        /// FAAMCU.
        /// </summary>
        public const string FAAMCU = "FAAMCU";

        /// <summary>
        /// FAAOBJ.
        /// </summary>
        public const string FAAOBJ = "FAAOBJ";

        /// <summary>
        /// FAASUB.
        /// </summary>
        public const string FAASUB = "FAASUB";

        /// <summary>
        /// FADMCU.
        /// </summary>
        public const string FADMCU = "FADMCU";

        /// <summary>
        /// FADOBJ.
        /// </summary>
        public const string FADOBJ = "FADOBJ";

        /// <summary>
        /// FADSUB.
        /// </summary>
        public const string FADSUB = "FADSUB";

        /// <summary>
        /// FADAJ.
        /// </summary>
        public const string FADAJ = "FADAJ";

        /// <summary>
        /// FAPDCT.
        /// </summary>
        public const string FAPDCT = "FAPDCT";

        /// <summary>
        /// FABSSR.
        /// </summary>
        public const string FABSSR = "FABSSR";

        /// <summary>
        /// FADOC.
        /// </summary>
        public const string FADOC = "FADOC";

        /// <summary>
        /// FAA12OW.
        /// </summary>
        public const string FAA12OW = "FAA12OW";

        /// <summary>
        /// FABRVS2.
        /// </summary>
        public const string FABRVS2 = "FABRVS2";

        /// <summary>
        /// FATRN.
        /// </summary>
        public const string FATRN = "FATRN";

        /// <summary>
        /// FADSD.
        /// </summary>
        public const string FADSD = "FADSD";

        /// <summary>
        /// FADRAT.
        /// </summary>
        public const string FADRAT = "FADRAT";

        /// <summary>
        /// FAAPYC.
        /// </summary>
        public const string FAAPYC = "FAAPYC";

        /// <summary>
        /// FAAWTD.
        /// </summary>
        public const string FAAWTD = "FAAWTD";

        /// <summary>
        /// FADSP.
        /// </summary>
        public const string FADSP = "FADSP";

        /// <summary>
        /// FARDOR.
        /// </summary>
        public const string FARDOR = "FARDOR";

        /// <summary>
        /// FACO.
        /// </summary>
        public const string FACO = "FACO";

        /// <summary>
        /// FATORG.
        /// </summary>
        public const string FATORG = "FATORG";

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
    public override string TableName => "F76B8200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FANUMB", "FANUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FANORU", "FANORU", JdeDataType.String, 2),
        new JdeField("FAAAID", "FAAAID", JdeDataType.Numeric),
        new JdeField("FADL01", "FADL01", JdeDataType.String, 60),
        new JdeField("FADL02", "FADL02", JdeDataType.String, 60),
        new JdeField("FADL03", "FADL03", JdeDataType.String, 60),
        new JdeField("FAAMCU", "FAAMCU", JdeDataType.String, 24),
        new JdeField("FAAOBJ", "FAAOBJ", JdeDataType.String, 12),
        new JdeField("FAASUB", "FAASUB", JdeDataType.String, 16),
        new JdeField("FADMCU", "FADMCU", JdeDataType.String, 24),
        new JdeField("FADOBJ", "FADOBJ", JdeDataType.String, 12),
        new JdeField("FADSUB", "FADSUB", JdeDataType.String, 16),
        new JdeField("FADAJ", "FADAJ", JdeDataType.Numeric),
        new JdeField("FAPDCT", "FAPDCT", JdeDataType.String, 4),
        new JdeField("FABSSR", "FABSSR", JdeDataType.String, 10),
        new JdeField("FADOC", "FADOC", JdeDataType.Numeric),
        new JdeField("FAA12OW", "FAA12OW", JdeDataType.Numeric),
        new JdeField("FABRVS2", "FABRVS2", JdeDataType.Numeric),
        new JdeField("FATRN", "FATRN", JdeDataType.String, 30),
        new JdeField("FADSD", "FADSD", JdeDataType.Numeric),
        new JdeField("FADRAT", "FADRAT", JdeDataType.Numeric),
        new JdeField("FAAPYC", "FAAPYC", JdeDataType.Numeric),
        new JdeField("FAAWTD", "FAAWTD", JdeDataType.Numeric),
        new JdeField("FADSP", "FADSP", JdeDataType.Numeric),
        new JdeField("FARDOR", "FARDOR", JdeDataType.String, 2),
        new JdeField("FACO", "FACO", JdeDataType.String, 10),
        new JdeField("FATORG", "FATORG", JdeDataType.String, 20),
        new JdeField("FAUSER", "FAUSER", JdeDataType.String, 20),
        new JdeField("FAPID", "FAPID", JdeDataType.String, 20),
        new JdeField("FAJOBN", "FAJOBN", JdeDataType.String, 20),
        new JdeField("FAUPMJ", "FAUPMJ", JdeDataType.Numeric),
        new JdeField("FAUPMT", "FAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B8200_0", "Primary Key on FANUMB", new[] { "FANUMB" }, isUnique: true, isPrimaryKey: true)
    };
}
