using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E16 - .
/// </summary>
public class F43E16 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P3KCOO.
        /// </summary>
        public const string P3KCOO = "P3KCOO";

        /// <summary>
        /// P3DOCO.
        /// </summary>
        public const string P3DOCO = "P3DOCO";

        /// <summary>
        /// P3DCTO.
        /// </summary>
        public const string P3DCTO = "P3DCTO";

        /// <summary>
        /// P3SFXO.
        /// </summary>
        public const string P3SFXO = "P3SFXO";

        /// <summary>
        /// P3LNID.
        /// </summary>
        public const string P3LNID = "P3LNID";

        /// <summary>
        /// P3DLNID.
        /// </summary>
        public const string P3DLNID = "P3DLNID";

        /// <summary>
        /// P3ANI.
        /// </summary>
        public const string P3ANI = "P3ANI";

        /// <summary>
        /// P3AID.
        /// </summary>
        public const string P3AID = "P3AID";

        /// <summary>
        /// P3OMCU.
        /// </summary>
        public const string P3OMCU = "P3OMCU";

        /// <summary>
        /// P3OBJ.
        /// </summary>
        public const string P3OBJ = "P3OBJ";

        /// <summary>
        /// P3SUB.
        /// </summary>
        public const string P3SUB = "P3SUB";

        /// <summary>
        /// P3DL01.
        /// </summary>
        public const string P3DL01 = "P3DL01";

        /// <summary>
        /// P3SBL.
        /// </summary>
        public const string P3SBL = "P3SBL";

        /// <summary>
        /// P3SBLT.
        /// </summary>
        public const string P3SBLT = "P3SBLT";

        /// <summary>
        /// P3DGL.
        /// </summary>
        public const string P3DGL = "P3DGL";

        /// <summary>
        /// P3PN.
        /// </summary>
        public const string P3PN = "P3PN";

        /// <summary>
        /// P3FY.
        /// </summary>
        public const string P3FY = "P3FY";

        /// <summary>
        /// P3CTRY.
        /// </summary>
        public const string P3CTRY = "P3CTRY";

        /// <summary>
        /// P3R001.
        /// </summary>
        public const string P3R001 = "P3R001";

        /// <summary>
        /// P3CO.
        /// </summary>
        public const string P3CO = "P3CO";

        /// <summary>
        /// P3UOVR.
        /// </summary>
        public const string P3UOVR = "P3UOVR";

        /// <summary>
        /// P3MAST.
        /// </summary>
        public const string P3MAST = "P3MAST";

        /// <summary>
        /// P3MASP.
        /// </summary>
        public const string P3MASP = "P3MASP";

        /// <summary>
        /// P3MASA.
        /// </summary>
        public const string P3MASA = "P3MASA";

        /// <summary>
        /// P3MASU.
        /// </summary>
        public const string P3MASU = "P3MASU";

        /// <summary>
        /// P3MASF.
        /// </summary>
        public const string P3MASF = "P3MASF";

        /// <summary>
        /// P3UORG.
        /// </summary>
        public const string P3UORG = "P3UORG";

        /// <summary>
        /// P3URLV.
        /// </summary>
        public const string P3URLV = "P3URLV";

        /// <summary>
        /// P3AEXP.
        /// </summary>
        public const string P3AEXP = "P3AEXP";

        /// <summary>
        /// P3ARLV.
        /// </summary>
        public const string P3ARLV = "P3ARLV";

        /// <summary>
        /// P3CRCD.
        /// </summary>
        public const string P3CRCD = "P3CRCD";

        /// <summary>
        /// P3FEA.
        /// </summary>
        public const string P3FEA = "P3FEA";

        /// <summary>
        /// P3DECDJ.
        /// </summary>
        public const string P3DECDJ = "P3DECDJ";

        /// <summary>
        /// P3ERBE.
        /// </summary>
        public const string P3ERBE = "P3ERBE";

        /// <summary>
        /// P3URCD.
        /// </summary>
        public const string P3URCD = "P3URCD";

        /// <summary>
        /// P3URDT.
        /// </summary>
        public const string P3URDT = "P3URDT";

        /// <summary>
        /// P3URAT.
        /// </summary>
        public const string P3URAT = "P3URAT";

        /// <summary>
        /// P3URAB.
        /// </summary>
        public const string P3URAB = "P3URAB";

        /// <summary>
        /// P3URRF.
        /// </summary>
        public const string P3URRF = "P3URRF";

        /// <summary>
        /// P3USER.
        /// </summary>
        public const string P3USER = "P3USER";

        /// <summary>
        /// P3PID.
        /// </summary>
        public const string P3PID = "P3PID";

        /// <summary>
        /// P3JOBN.
        /// </summary>
        public const string P3JOBN = "P3JOBN";

        /// <summary>
        /// P3UPMJ.
        /// </summary>
        public const string P3UPMJ = "P3UPMJ";

        /// <summary>
        /// P3TDAY.
        /// </summary>
        public const string P3TDAY = "P3TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43E16";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P3KCOO", "P3KCOO", JdeDataType.String, 10, true, true),
        new JdeField("P3DOCO", "P3DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P3DCTO", "P3DCTO", JdeDataType.String, 4, true, true),
        new JdeField("P3SFXO", "P3SFXO", JdeDataType.String, 6, true, true),
        new JdeField("P3LNID", "P3LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P3DLNID", "P3DLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P3ANI", "P3ANI", JdeDataType.String, 58),
        new JdeField("P3AID", "P3AID", JdeDataType.String, 16),
        new JdeField("P3OMCU", "P3OMCU", JdeDataType.String, 24),
        new JdeField("P3OBJ", "P3OBJ", JdeDataType.String, 12),
        new JdeField("P3SUB", "P3SUB", JdeDataType.String, 16),
        new JdeField("P3DL01", "P3DL01", JdeDataType.String, 60),
        new JdeField("P3SBL", "P3SBL", JdeDataType.String, 16),
        new JdeField("P3SBLT", "P3SBLT", JdeDataType.String, 2),
        new JdeField("P3DGL", "P3DGL", JdeDataType.Numeric),
        new JdeField("P3PN", "P3PN", JdeDataType.Numeric),
        new JdeField("P3FY", "P3FY", JdeDataType.Numeric),
        new JdeField("P3CTRY", "P3CTRY", JdeDataType.Numeric),
        new JdeField("P3R001", "P3R001", JdeDataType.String, 6),
        new JdeField("P3CO", "P3CO", JdeDataType.String, 10),
        new JdeField("P3UOVR", "P3UOVR", JdeDataType.String, 2),
        new JdeField("P3MAST", "P3MAST", JdeDataType.String, 2),
        new JdeField("P3MASP", "P3MASP", JdeDataType.Numeric),
        new JdeField("P3MASA", "P3MASA", JdeDataType.Numeric),
        new JdeField("P3MASU", "P3MASU", JdeDataType.Numeric),
        new JdeField("P3MASF", "P3MASF", JdeDataType.Numeric),
        new JdeField("P3UORG", "P3UORG", JdeDataType.Numeric),
        new JdeField("P3URLV", "P3URLV", JdeDataType.Numeric),
        new JdeField("P3AEXP", "P3AEXP", JdeDataType.Numeric),
        new JdeField("P3ARLV", "P3ARLV", JdeDataType.Numeric),
        new JdeField("P3CRCD", "P3CRCD", JdeDataType.String, 6),
        new JdeField("P3FEA", "P3FEA", JdeDataType.Numeric),
        new JdeField("P3DECDJ", "P3DECDJ", JdeDataType.Numeric),
        new JdeField("P3ERBE", "P3ERBE", JdeDataType.String, 2),
        new JdeField("P3URCD", "P3URCD", JdeDataType.String, 4),
        new JdeField("P3URDT", "P3URDT", JdeDataType.Numeric),
        new JdeField("P3URAT", "P3URAT", JdeDataType.Numeric),
        new JdeField("P3URAB", "P3URAB", JdeDataType.Numeric),
        new JdeField("P3URRF", "P3URRF", JdeDataType.String, 30),
        new JdeField("P3USER", "P3USER", JdeDataType.String, 20),
        new JdeField("P3PID", "P3PID", JdeDataType.String, 20),
        new JdeField("P3JOBN", "P3JOBN", JdeDataType.String, 20),
        new JdeField("P3UPMJ", "P3UPMJ", JdeDataType.Numeric),
        new JdeField("P3TDAY", "P3TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E16_0", "Primary Key on P3DOCO, P3DCTO, P3KCOO, P3SFXO, P3LNID, P3DLNID", new[] { "P3DOCO", "P3DCTO", "P3KCOO", "P3SFXO", "P3LNID", "P3DLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43E16_1", "Index on P3DOCO, P3DCTO, P3KCOO, P3SFXO, P3LNID, P3AID, P3SBLT, P3SBL, P3DGL", new[] { "P3DOCO", "P3DCTO", "P3KCOO", "P3SFXO", "P3LNID", "P3AID", "P3SBLT", "P3SBL", "P3DGL" })
    };
}
