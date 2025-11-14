using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B50 - .
/// </summary>
public class F76H3B50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LPH76LOPN.
        /// </summary>
        public const string LPH76LOPN = "LPH76LOPN";

        /// <summary>
        /// LPH76LECO.
        /// </summary>
        public const string LPH76LECO = "LPH76LECO";

        /// <summary>
        /// LPH76LEDT.
        /// </summary>
        public const string LPH76LEDT = "LPH76LEDT";

        /// <summary>
        /// LPH76EMS.
        /// </summary>
        public const string LPH76EMS = "LPH76EMS";

        /// <summary>
        /// LPH76LSTS.
        /// </summary>
        public const string LPH76LSTS = "LPH76LSTS";

        /// <summary>
        /// LPH76LCDT.
        /// </summary>
        public const string LPH76LCDT = "LPH76LCDT";

        /// <summary>
        /// LPH76LCTI.
        /// </summary>
        public const string LPH76LCTI = "LPH76LCTI";

        /// <summary>
        /// LPRMK.
        /// </summary>
        public const string LPRMK = "LPRMK";

        /// <summary>
        /// LPCRRM.
        /// </summary>
        public const string LPCRRM = "LPCRRM";

        /// <summary>
        /// LPCRCD.
        /// </summary>
        public const string LPCRCD = "LPCRCD";

        /// <summary>
        /// LPH76TORG.
        /// </summary>
        public const string LPH76TORG = "LPH76TORG";

        /// <summary>
        /// LPH76PRFL.
        /// </summary>
        public const string LPH76PRFL = "LPH76PRFL";

        /// <summary>
        /// LPH76FUC.
        /// </summary>
        public const string LPH76FUC = "LPH76FUC";

        /// <summary>
        /// LPH76FUD.
        /// </summary>
        public const string LPH76FUD = "LPH76FUD";

        /// <summary>
        /// LPH76FUR.
        /// </summary>
        public const string LPH76FUR = "LPH76FUR";

        /// <summary>
        /// LPH76FUA.
        /// </summary>
        public const string LPH76FUA = "LPH76FUA";

        /// <summary>
        /// LPH76FUF.
        /// </summary>
        public const string LPH76FUF = "LPH76FUF";

        /// <summary>
        /// LPTORG.
        /// </summary>
        public const string LPTORG = "LPTORG";

        /// <summary>
        /// LPUSER.
        /// </summary>
        public const string LPUSER = "LPUSER";

        /// <summary>
        /// LPPID.
        /// </summary>
        public const string LPPID = "LPPID";

        /// <summary>
        /// LPJOBN.
        /// </summary>
        public const string LPJOBN = "LPJOBN";

        /// <summary>
        /// LPUPMJ.
        /// </summary>
        public const string LPUPMJ = "LPUPMJ";

        /// <summary>
        /// LPUPMT.
        /// </summary>
        public const string LPUPMT = "LPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LPH76LOPN", "LPH76LOPN", JdeDataType.Numeric, null, true, true),
        new JdeField("LPH76LECO", "LPH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("LPH76LEDT", "LPH76LEDT", JdeDataType.String, 6, true, true),
        new JdeField("LPH76EMS", "LPH76EMS", JdeDataType.String, 8, true, true),
        new JdeField("LPH76LSTS", "LPH76LSTS", JdeDataType.String, 2),
        new JdeField("LPH76LCDT", "LPH76LCDT", JdeDataType.Numeric),
        new JdeField("LPH76LCTI", "LPH76LCTI", JdeDataType.Numeric),
        new JdeField("LPRMK", "LPRMK", JdeDataType.String, 60),
        new JdeField("LPCRRM", "LPCRRM", JdeDataType.String, 2),
        new JdeField("LPCRCD", "LPCRCD", JdeDataType.String, 6),
        new JdeField("LPH76TORG", "LPH76TORG", JdeDataType.String, 6),
        new JdeField("LPH76PRFL", "LPH76PRFL", JdeDataType.String, 2),
        new JdeField("LPH76FUC", "LPH76FUC", JdeDataType.String, 20),
        new JdeField("LPH76FUD", "LPH76FUD", JdeDataType.Numeric),
        new JdeField("LPH76FUR", "LPH76FUR", JdeDataType.String, 30),
        new JdeField("LPH76FUA", "LPH76FUA", JdeDataType.Numeric),
        new JdeField("LPH76FUF", "LPH76FUF", JdeDataType.String, 2),
        new JdeField("LPTORG", "LPTORG", JdeDataType.String, 20),
        new JdeField("LPUSER", "LPUSER", JdeDataType.String, 20),
        new JdeField("LPPID", "LPPID", JdeDataType.String, 20),
        new JdeField("LPJOBN", "LPJOBN", JdeDataType.String, 20),
        new JdeField("LPUPMJ", "LPUPMJ", JdeDataType.Numeric),
        new JdeField("LPUPMT", "LPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B50_0", "Primary Key on LPH76LOPN, LPH76LECO, LPH76LEDT, LPH76EMS", new[] { "LPH76LOPN", "LPH76LECO", "LPH76LEDT", "LPH76EMS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H3B50_2", "Index on LPH76LCDT, LPH76LCTI", new[] { "LPH76LCDT", "LPH76LCTI" }),
        new JdeIndex("F76H3B50_3", "Index on LPH76LECO, LPH76LEDT, LPH76EMS", new[] { "LPH76LECO", "LPH76LEDT", "LPH76EMS" })
    };
}
