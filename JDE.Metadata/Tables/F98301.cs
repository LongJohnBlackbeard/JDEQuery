using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98301 - .
/// </summary>
public class F98301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DEPID.
        /// </summary>
        public const string DEPID = "DEPID";

        /// <summary>
        /// DEVERS.
        /// </summary>
        public const string DEVERS = "DEVERS";

        /// <summary>
        /// DETY.
        /// </summary>
        public const string DETY = "DETY";

        /// <summary>
        /// DESQN.
        /// </summary>
        public const string DESQN = "DESQN";

        /// <summary>
        /// DEOPT#.
        /// </summary>
        public const string DEOPT_ = "DEOPT#";

        /// <summary>
        /// DEDWTY.
        /// </summary>
        public const string DEDWTY = "DEDWTY";

        /// <summary>
        /// DEFILN.
        /// </summary>
        public const string DEFILN = "DEFILN";

        /// <summary>
        /// DEPFX.
        /// </summary>
        public const string DEPFX = "DEPFX";

        /// <summary>
        /// DEMID.
        /// </summary>
        public const string DEMID = "DEMID";

        /// <summary>
        /// DEFMAT.
        /// </summary>
        public const string DEFMAT = "DEFMAT";

        /// <summary>
        /// DELGF.
        /// </summary>
        public const string DELGF = "DELGF";

        /// <summary>
        /// DEJEX.
        /// </summary>
        public const string DEJEX = "DEJEX";

        /// <summary>
        /// DEEXCL.
        /// </summary>
        public const string DEEXCL = "DEEXCL";

        /// <summary>
        /// DEOUTM.
        /// </summary>
        public const string DEOUTM = "DEOUTM";

        /// <summary>
        /// DEUSER.
        /// </summary>
        public const string DEUSER = "DEUSER";

        /// <summary>
        /// DEVCD.
        /// </summary>
        public const string DEVCD = "DEVCD";

        /// <summary>
        /// DEVED.
        /// </summary>
        public const string DEVED = "DEVED";

        /// <summary>
        /// DEPTSP.
        /// </summary>
        public const string DEPTSP = "DEPTSP";

        /// <summary>
        /// DEPTIN.
        /// </summary>
        public const string DEPTIN = "DEPTIN";

        /// <summary>
        /// DEHJBQ.
        /// </summary>
        public const string DEHJBQ = "DEHJBQ";

        /// <summary>
        /// DETXT1.
        /// </summary>
        public const string DETXT1 = "DETXT1";

        /// <summary>
        /// DEKOPT.
        /// </summary>
        public const string DEKOPT = "DEKOPT";

        /// <summary>
        /// DEFLDN.
        /// </summary>
        public const string DEFLDN = "DEFLDN";

        /// <summary>
        /// DEDTAS.
        /// </summary>
        public const string DEDTAS = "DEDTAS";

        /// <summary>
        /// DEDTAT.
        /// </summary>
        public const string DEDTAT = "DEDTAT";

        /// <summary>
        /// DECDEC.
        /// </summary>
        public const string DECDEC = "DECDEC";

        /// <summary>
        /// DEEC.
        /// </summary>
        public const string DEEC = "DEEC";

        /// <summary>
        /// DEDFLD.
        /// </summary>
        public const string DEDFLD = "DEDFLD";

        /// <summary>
        /// DERJST.
        /// </summary>
        public const string DERJST = "DERJST";

        /// <summary>
        /// DEAO.
        /// </summary>
        public const string DEAO = "DEAO";

        /// <summary>
        /// DESVL.
        /// </summary>
        public const string DESVL = "DESVL";

        /// <summary>
        /// DEVALR.
        /// </summary>
        public const string DEVALR = "DEVALR";

        /// <summary>
        /// DESTY.
        /// </summary>
        public const string DESTY = "DESTY";

        /// <summary>
        /// DEMCRG.
        /// </summary>
        public const string DEMCRG = "DEMCRG";

        /// <summary>
        /// DEAALL.
        /// </summary>
        public const string DEAALL = "DEAALL";

        /// <summary>
        /// DESAD.
        /// </summary>
        public const string DESAD = "DESAD";

        /// <summary>
        /// DETXTO.
        /// </summary>
        public const string DETXTO = "DETXTO";

        /// <summary>
        /// DELTOT.
        /// </summary>
        public const string DELTOT = "DELTOT";

        /// <summary>
        /// DEPAGE.
        /// </summary>
        public const string DEPAGE = "DEPAGE";

        /// <summary>
        /// DETYT.
        /// </summary>
        public const string DETYT = "DETYT";

        /// <summary>
        /// DEOQSO.
        /// </summary>
        public const string DEOQSO = "DEOQSO";

        /// <summary>
        /// DEOQOP.
        /// </summary>
        public const string DEOQOP = "DEOQOP";

        /// <summary>
        /// DEOQOO.
        /// </summary>
        public const string DEOQOO = "DEOQOO";

        /// <summary>
        /// DEOQOU.
        /// </summary>
        public const string DEOQOU = "DEOQOU";

        /// <summary>
        /// DEOQOD.
        /// </summary>
        public const string DEOQOD = "DEOQOD";
    }

    /// <inheritdoc />
    public override string TableName => "F98301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DEPID", "DEPID", JdeDataType.String, 20, true, true),
        new JdeField("DEVERS", "DEVERS", JdeDataType.String, 20, true, true),
        new JdeField("DETY", "DETY", JdeDataType.String, 2, true, true),
        new JdeField("DESQN", "DESQN", JdeDataType.Numeric, null, true, true),
        new JdeField("DEOPT#", "DEOPT#", JdeDataType.Numeric),
        new JdeField("DEDWTY", "DEDWTY", JdeDataType.String, 2),
        new JdeField("DEFILN", "DEFILN", JdeDataType.String, 20),
        new JdeField("DEPFX", "DEPFX", JdeDataType.String, 4),
        new JdeField("DEMID", "DEMID", JdeDataType.String, 20),
        new JdeField("DEFMAT", "DEFMAT", JdeDataType.String, 20),
        new JdeField("DELGF", "DELGF", JdeDataType.String, 20),
        new JdeField("DEJEX", "DEJEX", JdeDataType.String, 20),
        new JdeField("DEEXCL", "DEEXCL", JdeDataType.String, 2),
        new JdeField("DEOUTM", "DEOUTM", JdeDataType.String, 6),
        new JdeField("DEUSER", "DEUSER", JdeDataType.String, 20),
        new JdeField("DEVCD", "DEVCD", JdeDataType.Numeric),
        new JdeField("DEVED", "DEVED", JdeDataType.Numeric),
        new JdeField("DEPTSP", "DEPTSP", JdeDataType.String, 2),
        new JdeField("DEPTIN", "DEPTIN", JdeDataType.String, 2),
        new JdeField("DEHJBQ", "DEHJBQ", JdeDataType.String, 2),
        new JdeField("DETXT1", "DETXT1", JdeDataType.String, 100),
        new JdeField("DEKOPT", "DEKOPT", JdeDataType.String, 2),
        new JdeField("DEFLDN", "DEFLDN", JdeDataType.String, 12),
        new JdeField("DEDTAS", "DEDTAS", JdeDataType.Numeric),
        new JdeField("DEDTAT", "DEDTAT", JdeDataType.String, 2),
        new JdeField("DECDEC", "DECDEC", JdeDataType.String, 2),
        new JdeField("DEEC", "DEEC", JdeDataType.String, 2),
        new JdeField("DEDFLD", "DEDFLD", JdeDataType.String, 2),
        new JdeField("DERJST", "DERJST", JdeDataType.String, 2),
        new JdeField("DEAO", "DEAO", JdeDataType.String, 2),
        new JdeField("DESVL", "DESVL", JdeDataType.String, 50),
        new JdeField("DEVALR", "DEVALR", JdeDataType.String, 4),
        new JdeField("DESTY", "DESTY", JdeDataType.String, 2),
        new JdeField("DEMCRG", "DEMCRG", JdeDataType.String, 2),
        new JdeField("DEAALL", "DEAALL", JdeDataType.String, 2),
        new JdeField("DESAD", "DESAD", JdeDataType.String, 2),
        new JdeField("DETXTO", "DETXTO", JdeDataType.String, 2),
        new JdeField("DELTOT", "DELTOT", JdeDataType.Numeric),
        new JdeField("DEPAGE", "DEPAGE", JdeDataType.String, 2),
        new JdeField("DETYT", "DETYT", JdeDataType.String, 2),
        new JdeField("DEOQSO", "DEOQSO", JdeDataType.String, 2),
        new JdeField("DEOQOP", "DEOQOP", JdeDataType.String, 2),
        new JdeField("DEOQOO", "DEOQOO", JdeDataType.String, 2),
        new JdeField("DEOQOU", "DEOQOU", JdeDataType.String, 2),
        new JdeField("DEOQOD", "DEOQOD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98301_0", "Primary Key on DEPID, DEVERS, DETY, DESQN", new[] { "DEPID", "DEVERS", "DETY", "DESQN" }, isUnique: true, isPrimaryKey: true)
    };
}
